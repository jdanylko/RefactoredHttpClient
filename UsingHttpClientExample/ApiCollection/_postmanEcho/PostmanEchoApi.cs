using System.Net.Http;
using System.Threading.Tasks;
using UsingHttpClientExample.ApiCollection._postmanEcho.Models;

namespace UsingHttpClientExample.ApiCollection._postmanEcho
{
    public class PostmanEchoApi : BasePostmanEchoApi, IPostmanEchoApi
    {
        public PostmanEchoApi(IHttpClientFactory factory) : base(factory)
        {
            BasePath = "/get";
        }

        public async Task<PostmanEchoResponse> GetEchoAsync(string foo)
        {
            var message = GetHttpRequestBuilder(BasePath)
                .AddQueryString("foo", foo)
                .GetHttpMessage();

            return await base.SendRequest<PostmanEchoResponse>(message);
        }
    }
}