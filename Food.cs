using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сервер
{
    public class Food 
    {
        public string ID { get; set; }
        public string Amount { get; set; }
        public string Price { get; set; }
        public string Weight { get; set; }
        public string Name { get; set; }
        public string Manufactures { get; set; }
        public string ExpirationDate { get; set; }
        public string Country { get; set; }

        public Food(string id, string amount, string price, string weight, string name, string manufactures, string expirationdate, string country)
        {
            this.ID = id;
            this.Amount = amount;
            this.Price = price;
            this.Weight = weight;
            this.Name = name;
            this.Manufactures = manufactures;
            this.ExpirationDate = expirationdate;
            this.Country = country;

        }
    }
}
