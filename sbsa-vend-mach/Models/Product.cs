using System;

namespace sbsa_vend_mach.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set;}
    }
}