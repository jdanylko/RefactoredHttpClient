using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Options;
using UsingHttpClientExample.Configuration;
using UsingHttpClientExample.Extensions;
using UsingHttpClientExample.Infrastructure;

namespace UsingHttpClientExample.ApiCollection.Marvel
{
    public class BaseMarvelApi : BaseHttpClientWithFactory
    {
        private readonly MarvelApiConfig _config;

        public BaseMarvelApi(IHttpClientFactory factory, IOptions<MarvelApiConfig> config) : base(factory)
        {
            _config = config.Value;
        }

        public override HttpRequestBuilder GetHttpRequestBuilder(string path)
        {
            var query = GetQueryString();

            return new HttpRequestBuilder(_config.BaseAddress)
                .SetPath(_config.Version)
                .AddToPath("public")
                .AddToPath(path)
                .SetQueryString(query.ToQueryString())
                .HttpMethod(HttpMethod.Get)
                .Headers(headers =>
                    headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")));
        }

        public NameValueCollection GetQueryString()
        {
            var current = DateTime.UtcNow.ToString("s");
            return new NameValueCollection
            {
                { "ts", current },
                { "apikey", _config.PublicKey }, // nope, can't show the public key.
                { "hash", GetApiKey(current) }
            };
        }

        public string GetApiKey(string ts)
        {
            using (MD5 md5 = MD5.Create())
            {
                return GetHash(md5, ts + _config.PrivateKey + _config.PublicKey);
            }
        }

        private string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            var data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
