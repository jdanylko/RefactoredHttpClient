namespace UsingHttpClientExample.Configuration
{
    public class MarvelApiConfig
    {
        public const string MarvelSection = nameof(MarvelApiConfig);

        public string BaseAddress { get; set; }
        public string Version { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
    }
}