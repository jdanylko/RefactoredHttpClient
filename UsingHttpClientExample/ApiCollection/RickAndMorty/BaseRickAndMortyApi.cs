using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Options;
using UsingHttpClientExample.Configuration;
using UsingHttpClientExample.Infrastructure;

namespace UsingHttpClientExample.ApiCollection.RickAndMorty
{
    public class BaseRickAndMortyApi : BaseHttpClientWithFactory
    {
        private readonly RickAndMortyApiConfig _config;

        public BaseRickAndMortyApi(IHttpClientFactory factory, 
            IOptions<RickAndMortyApiConfig> config) : base(factory)
        {
            _config = config.Value;
        }

        public override HttpRequestBuilder GetHttpRequestBuilder(string path)
        {
            return new HttpRequestBuilder(_config.BaseAddress)
                .SetPath("api")
                .AddToPath(path)
                .HttpMethod(HttpMethod.Get)
                .Headers(headers =>
                    headers.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json")));
        }
    }
}