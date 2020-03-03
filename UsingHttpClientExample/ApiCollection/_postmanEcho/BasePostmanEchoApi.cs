using System.Net.Http;
using System.Net.Http.Headers;
using UsingHttpClientExample.Infrastructure;

namespace UsingHttpClientExample.ApiCollection._postmanEcho
{
    public class BasePostmanEchoApi : BaseHttpClientWithFactory
    {
        private const string baseAddress = "https://postman-echo.com/";

        public BasePostmanEchoApi(IHttpClientFactory factory) : base(factory) { }

        public override HttpRequestBuilder GetHttpRequestBuilder(string path)
        {
            return new HttpRequestBuilder(baseAddress)
                .AddToPath(path)
                .HttpMethod(HttpMethod.Get)
                .Headers(headers =>
                    headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")));
        }
    }
}