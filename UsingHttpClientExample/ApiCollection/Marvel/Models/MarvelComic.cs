namespace UsingHttpClientExample.ApiCollection.Marvel.Models
{

    public class MarvelComic
    {
        public string code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public Data data { get; set; }
        public string etag { get; set; }
    }

    public class Data
    {
        public string offset { get; set; }
        public string limit { get; set; }
        public string total { get; set; }
        public string count { get; set; }
        public Result[] results { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string digitalId { get; set; }
        public string title { get; set; }
        public string issueNumber { get; set; }
        public string variantDescription { get; set; }
        public string description { get; set; }
        public string modified { get; set; }
        public string isbn { get; set; }
        public string upc { get; set; }
        public string diamondCode { get; set; }
        public string ean { get; set; }
        public string issn { get; set; }
        public string format { get; set; }
        public string pageCount { get; set; }
        public Textobject[] textObjects { get; set; }
        public string resourceURI { get; set; }
        public Url[] urls { get; set; }
        public Series series { get; set; }
        public Variant[] variants { get; set; }
        public Collection[] collections { get; set; }
        public Collectedissue[] collectedIssues { get; set; }
        public Date[] dates { get; set; }
        public Price[] prices { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Image[] images { get; set; }
        public Creators creators { get; set; }
        public Characters characters { get; set; }
        public Stories stories { get; set; }
        public Events events { get; set; }
    }

    public class Series
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }

    public class Thumbnail
    {
        public string path { get; set; }
        public string extension { get; set; }
    }

    public class Creators
    {
        public string available { get; set; }
        public string returned { get; set; }
        public string collectionURI { get; set; }
        public Item[] items { get; set; }
    }

    public class Item
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string role { get; set; }
    }

    public class Characters
    {
        public string available { get; set; }
        public string returned { get; set; }
        public string collectionURI { get; set; }
        public Item1[] items { get; set; }
    }

    public class Item1
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string role { get; set; }
    }

    public class Stories
    {
        public string available { get; set; }
        public string returned { get; set; }
        public string collectionURI { get; set; }
        public Item2[] items { get; set; }
    }

    public class Item2
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Events
    {
        public string available { get; set; }
        public string returned { get; set; }
        public string collectionURI { get; set; }
        public Item3[] items { get; set; }
    }

    public class Item3
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }

    public class Textobject
    {
        public string type { get; set; }
        public string language { get; set; }
        public string text { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Variant
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }

    public class Collection
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }

    public class Collectedissue
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }

    public class Date
    {
        public string type { get; set; }
        public string date { get; set; }
    }

    public class Price
    {
        public string type { get; set; }
        public string price { get; set; }
    }

    public class Image
    {
        public string path { get; set; }
        public string extension { get; set; }
    }

}
