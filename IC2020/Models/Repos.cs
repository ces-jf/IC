using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IC2020.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public string description { get; set; }
        public string contributors_url { get; set; }
        public DateTime updated_at { get; set; }
        public string language { get; set; }
    }

    public class Repos
    {
        public List<Item> items { get; set; }
    }
}
