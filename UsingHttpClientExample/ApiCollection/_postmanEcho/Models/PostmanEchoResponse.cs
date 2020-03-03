namespace UsingHttpClientExample.ApiCollection._postmanEcho.Models
{

public class PostmanEchoResponse
{
    public Args args { get; set; }
    public Headers headers { get; set; }
    public string url { get; set; }
}

public class Args
{
    public string foo { get; set; }
}

public class Headers
{
    public string xforwardedproto { get; set; }
    public string host { get; set; }
    public string accept { get; set; }
    public string acceptencoding { get; set; }
    public string cachecontrol { get; set; }
    public string postmantoken { get; set; }
    public string useragent { get; set; }
    public string xforwardedport { get; set; }
}
}