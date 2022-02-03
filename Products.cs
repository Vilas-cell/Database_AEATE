using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сервер
{
    public class Products
    {
        public string ID { get; set; }
        public string Amount { get; set; }
        public string Price { get; set; }
        public string Weight { get; set; }
        public string Name { get; set; }
        public string Manufactures { get; set; }

        public Products(string id, string amount, string price, string weight, string name, string manufactures)
        {
            this.ID = id;
            this.Amount = amount;
            this.Price = price;
            this.Weight = weight;
            this.Name = name;
            this.Manufactures = manufactures;

        }
    }
}
