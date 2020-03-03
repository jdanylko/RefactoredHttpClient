using System.Threading.Tasks;
using UsingHttpClientExample.ApiCollection.RickAndMorty.Models;

namespace UsingHttpClientExample.ApiCollection.RickAndMorty
{
    public interface IRickAndMortyCharacterApi
    {
        Task<RickAndMortyCharacter> GetCharacters();
        Task<RickAndMortyCharacter> GetRickAndMorty();
    }
}