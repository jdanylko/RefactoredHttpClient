using System.Threading.Tasks;
using UsingHttpClientExample.ApiCollection.Marvel.Models;

namespace UsingHttpClientExample.ApiCollection.Marvel
{
    public interface IMarvelComicApi
    {
        Task<MarvelComic> GetComics();
        Task<MarvelComic> GetComicsByTitle(string title);
    }
}