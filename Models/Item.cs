using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pu_backend_cs.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
    }
}