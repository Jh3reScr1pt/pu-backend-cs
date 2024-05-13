using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pu_backend_cs.Models
{
    public class Ubication
    {
        public int id { get; set; }
        public string tower { get; set; }
        public string floor { get; set; }
        public bool state { get; set; } = true;
    }
}