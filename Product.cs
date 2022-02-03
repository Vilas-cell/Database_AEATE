using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_AEATE.Codes
{
     public class Product
     {

        public int Amount { get; set; }

        public float Price { get; set; }

        public float Weight { get; set; }

        public string Name { get; set; }

        public string Manufactures { get; set; }

        public Product(float price, float weight, string name, string manufactures, int amount)
        {

            Price = price;
            Name = name;
            Weight = weight;
            Manufactures = manufactures;
            Amount = amount;

        }

        public Product() { }

        

     }
}   
