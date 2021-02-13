using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.model
{
    public class Item
    {

        public virtual int id { get; set; }
        public virtual string item_name { get; set; }
        public virtual DateTime item_bought { get; set; }
        public virtual DateTime item_retired { get; set; }
        public virtual float price { get; set; }

        public virtual string company_name { get; set; }

        public virtual float rating { get; set; }

        public virtual string description { get; set; }

        public Item()
        {
            this.item_name = "";
            this.item_bought = new DateTime();
            this.item_retired = new DateTime();
            this.price = 0;
            this.description = "";
            this.company_name = "";
            this.rating = 0;
        }

        public Item(string item_name, DateTime item_bought, DateTime item_retired, float price, string description, string company_name, float rating, int id)
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

        public Item(string line)
        {
            string[] values = line.Split(';');
            this.id = int.Parse(values[0]);
            this.item_name = values[1];
            this.item_bought = Convert.ToDateTime(values[2]);
            this.item_retired = Convert.ToDateTime(values[3]);
            this.price = float.Parse(values[4]);
            this.description = values[5];
            this.company_name = values[6];
            this.rating = float.Parse(values[7]);


        }

        public virtual void setItemValues(Item item)
        {
            this.item_name = item.item_name;
            this.item_bought = item.item_bought;
            this.item_retired = item.item_retired;
            this.price = item.price;
            this.description = item.description;
            this.company_name = item.company_name;
            this.rating = item.rating;
            this.id = item.id;
        }
        public Item(Item item)
        {
            this.item_name = item.item_name;
            this.item_bought = item.item_bought;
            this.item_retired = item.item_retired;
            this.price = item.price;
            this.description = item.description;
            this.company_name = item.company_name;
            this.rating = item.rating;
            this.id = item.id;
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
        public virtual string to_csv()
        {

            return this.id.ToString() + ";" + this.item_name + ";" + this.item_bought.ToString() + ";" + this.item_retired.ToString() + ";" + this.price.ToString() + ";" + this.description + ";" + this.company_name + ";" + this.rating.ToString();
        }
    }
}
