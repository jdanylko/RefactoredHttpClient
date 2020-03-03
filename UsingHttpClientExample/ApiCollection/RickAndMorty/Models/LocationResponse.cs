using System;

namespace UsingHttpClientExample.ApiCollection.RickAndMorty.Models
{

    public class LocationResponse
    {
        public Info info { get; set; }
        public LocationModel[] results { get; set; }
    }


    public class LocationModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string dimension { get; set; }
        public string[] residents { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
    }

}
