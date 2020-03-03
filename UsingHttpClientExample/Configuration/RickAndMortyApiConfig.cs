namespace UsingHttpClientExample.Configuration
{
    public class RickAndMortyApiConfig
    {
        public const string RickAndMortySection = nameof(RickAndMortyApiConfig);

        public string BaseAddress { get; set; }
    }
}