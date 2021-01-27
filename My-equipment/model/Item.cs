using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.model
{
     public class Item
    {

        public int id { get; set; }
        public string item_name { get; set; }
        public DateTime item_bought { get; set; }
        public DateTime item_retired { get; set; }
        public float price { get; set; }
 
        public string company_name { get; set; }

        public float rating { get; set; }

        public string description { get; set; }

        public Item()
        {

        }
        public Item(string[] table)
        {

            item_name = table[0];
            description = table[1];
        }
        public Item (string item_name , DateTime item_bought, DateTime item_retired,float price , string description, string company_name,float rating,int id)
        {
            this.item_name = item_name;
            this.item_bought = item_bought;
            this.item_retired = item_retired;
            this.price = price;
            this.description = description;
            this.company_name = company_name;
            this.rating = rating;
            this.id = id;
        }
        public Item(string item_name, DateTime item_bought, DateTime item_retired, float price, string description, string company_name, float rating)
        {
            this.item_name = item_name;
            this.item_bought = item_bought;
            this.item_retired = item_retired;
            this.price = price;
            this.description = description;
            this.company_name = company_name;
            this.rating = rating;
        }

        public override string ToString()
        {
            return this.id.ToString() + " " + this.item_name + " " + this.item_bought.ToString() + " " + this.item_retired.ToString() + " " + this.price.ToString() + " " + this.description + " " + this.company_name + " " + this.rating.ToString();
        }
    }
}
