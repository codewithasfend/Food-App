using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Models
{
    public class PopularProduct
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string imageUrl { get; set; }

        public string FullImageUrl => AppSettings.ApiUrl + imageUrl;
    }
}
