using System.Collections.Specialized;
using System.Linq;

namespace UsingHttpClientExample.Extensions
{

    public static class NameValueCollectionExtensions
    {
        public static string ToQueryString(this NameValueCollection nvc)
        {
            return string.Join("&",
                nvc.AllKeys.Select(
                    key => string.Format("{0}={1}", key, nvc[key])));
        }
    }
}
