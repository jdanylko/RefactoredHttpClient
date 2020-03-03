using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using UsingHttpClientExample.ApiCollection.Marvel.Models;
using UsingHttpClientExample.Configuration;

namespace UsingHttpClientExample.ApiCollection.Marvel
{
public class MarvelComicApi : BaseMarvelApi, IMarvelComicApi
{
    private NameValueCollection SearchTerms { get; set; }

    public MarvelComicApi(IHttpClientFactory factory, 
        IOptions<MarvelApiConfig> config) : base(factory, config)
    {
        BasePath = "/comics";
    }

    public async Task<MarvelComic> GetComics()
    {
        var request = GetHttpRequestBuilder(BasePath);
        return await base.SendRequest<MarvelComic>(request.GetHttpMessage());
    }

    public async Task<MarvelComic> GetComicsByTitle(string title)
    {
        var request = GetHttpRequestBuilder(BasePath)
            .AddQueryString("title", title);

        return await base.SendRequest<MarvelComic>(request.GetHttpMessage());
    }
}
}
