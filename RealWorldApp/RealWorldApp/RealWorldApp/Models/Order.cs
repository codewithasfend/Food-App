using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Models
{
    public class Order
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public double orderTotal { get; set; }
        public DateTime orderPlaced { get; set; }
        public bool isOrderCompleted { get; set; }
        public int userId { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
