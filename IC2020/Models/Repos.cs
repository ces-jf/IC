using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IC2020.Models
{
    public class Item
    {
        public string url { get; set; }
        public string tag_name { get; set; }
        public DateTime published_at { get; set; }
        public Author author { get; set; }
    }

    public class Author
    {
        public string login { get; set; }
    }

    public class RepoInfo
    {
        public string id { get; set; }
        public string full_name { get; set; }
        public string language { get; set; }
        public string default_branch { get; set; }
        public int watchers_count { get; set; }
        public int open_issues_count { get; set; }
        public int forks { get; set; }
    }
}

