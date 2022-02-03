using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сервер
{
    public class Stationary
    {
        public string ID { get; set; }
        public string Amount { get; set; }
        public string Price { get; set; }
        public string Weight { get; set; }
        public string Name { get; set; }
        public string Manufactures { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Type { get; set; }
        public Stationary(string id, string amount, string price, string weight, string name, string manufactures, string color, string material, string type)
        {
            this.ID = id;
            this.Amount = amount;
            this.Price = price;
            this.Weight = weight;
            this.Name = name;
            this.Manufactures = manufactures;
            this.Color = color;
            this.Material = material;
            this.Type = type;
            

        }
    }
}
