using System;
using System.Net;
using LiteDB;

namespace IC2020.Models
{
    public class AuxOperations
    {
        public string GetStrFromJson(string url)
        {
            var rawJson = string.Empty;
            using (var client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.UserAgent] =
                        "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                    rawJson = client.DownloadString(url);
                }
                catch (Exception) { }
            }
            return rawJson;
        }

    }
}
