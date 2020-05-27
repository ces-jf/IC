using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IC2020.Models
{
    public class Collabs
    {
        public string login { get; set; }
        public int id { get; set; }
    }

    public class ObjStructure
    {
        public Item generalInfo { get; set; }
        public List<Collabs> collaborators { get; set; }

        public ObjStructure()
        {
            collaborators = new List<Collabs>();
        }

    }
}
