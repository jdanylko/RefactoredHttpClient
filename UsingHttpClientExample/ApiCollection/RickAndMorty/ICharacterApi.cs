using System.Threading.Tasks;
using UsingHttpClientExample.ApiCollection.RickAndMorty.Models;

namespace UsingHttpClientExample.ApiCollection.RickAndMorty
{
    public interface ICharacterApi
    {
        Task<CharacterResponse> GetCharacters();
        Task<CharacterModel> GetCharacter(int id);
    }
}