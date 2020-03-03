using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using UsingHttpClientExample.ApiCollection.RickAndMorty.Models;
using UsingHttpClientExample.Configuration;

namespace UsingHttpClientExample.ApiCollection.RickAndMorty
{
public class RickAndMortyCharacterApi : BaseRickAndMortyApi, IRickAndMortyCharacterApi
{
    public RickAndMortyCharacterApi(IHttpClientFactory factory, 
        IOptions<RickAndMortyApiConfig> config) : base(factory, config)
    {
        BasePath = "/character";
    }

    public async Task<RickAndMortyCharacter> GetCharacters()
    {
        var message = GetHttpRequestBuilder(BasePath)
            .GetHttpMessage();

        return await base.SendRequest<RickAndMortyCharacter>(message);
    }
    
    public async Task<RickAndMortyCharacter> GetRickAndMorty()
    {
        var message = GetHttpRequestBuilder(BasePath)
            .AddToPath("1,2")
            .GetHttpMessage();

        return await base.SendRequest<RickAndMortyCharacter>(message);
    }
}
}
