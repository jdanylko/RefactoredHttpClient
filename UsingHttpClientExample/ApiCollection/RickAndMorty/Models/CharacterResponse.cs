using System;

namespace UsingHttpClientExample.ApiCollection.RickAndMorty.Models
{
public class CharacterResponse
{
    public Info info { get; set; }
    public CharacterModel[] results { get; set; }
}

public class CharacterModel
{
    public int id { get; set; }
    public string name { get; set; }
    public string status { get; set; }
    public string species { get; set; }
    public string type { get; set; }
    public string gender { get; set; }
    public Origin origin { get; set; }
    public Location location { get; set; }
    public string image { get; set; }
    public string[] episode { get; set; }
    public string url { get; set; }
    public DateTime created { get; set; }
}

public class Origin
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Location
{
    public string name { get; set; }
    public string url { get; set; }
}

}
