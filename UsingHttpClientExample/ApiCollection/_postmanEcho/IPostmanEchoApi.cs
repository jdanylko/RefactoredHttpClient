using System.Threading.Tasks;
using UsingHttpClientExample.ApiCollection._postmanEcho.Models;

namespace UsingHttpClientExample.ApiCollection._postmanEcho
{
    public interface IPostmanEchoApi
    {
        Task<PostmanEchoResponse> GetEchoAsync(string foo);
    }
}