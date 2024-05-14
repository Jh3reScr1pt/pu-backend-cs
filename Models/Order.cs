using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace pu_backend_cs.Models
{
    public class Order
    {
        public Order()
        {
            orderNumber = new Random().Next(1,26);
            status = "Food Processing";
            date = DateTime.Now;
        }
        public int id { get; set; }
        public string userCI { get; set; }
        public List<Item> items { get; set; }
        public double amount { get; set; }
        public int ubicationId { get; set; }
        public int orderNumber { get; set; }
        public string status { get; set; } 
        public DateTime date { get; set; }
        public virtual Ubication? oUbication { get; set; }
    }
}