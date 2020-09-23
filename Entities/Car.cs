using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadTollAPI.Entities
{
    public class Car
    {
        public int id { set; get; }
        public string regnr { set; get;  }

        public Owner owner { set; get; }
    }
}
