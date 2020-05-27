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

        //public void DBInsert(Item fav)
        //{
        //    if (fav.id != 0)
        //    {
        //        using (var db = new LiteDatabase(@"Data/favorites.db"))
        //        {
        //            var items = db.GetCollection<Item>("items");
        //            var query = items.FindOne(x => x.id == fav.id);
        //            if (query == null)
        //            {
        //                items.Insert(fav);
        //            }
        //        }
        //    }
        //}

        //public void DBDelete(Item fav)
        //{
        //    if (fav.id != 0)
        //    {
        //        using (var db = new LiteDatabase(@"Data/favorites.db"))
        //        {
        //            var items = db.GetCollection<Item>("items");
        //            items.Delete(x => x.id == fav.id);
        //        }
        //    }
        //}
    }
}
