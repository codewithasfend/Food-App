using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public string imageUrl { get; set; }
        public double price { get; set; }
        public bool isPopularProduct { get; set; }
        public int categoryId { get; set; }
        public object imageArray { get; set; }

        public string FullImageUrl => AppSettings.ApiUrl + imageUrl;
    }
}
