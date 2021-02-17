using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.model
{
    public class Author : Generic_entity
    {

        public virtual int id { get; set; }
        public virtual string first_name { get; set; }
        public virtual string last_name { get; set; }
        public virtual DateTime birth_date { get; set; }

        public virtual IList<Book> books { get; set; }



        public Author()
        {
            first_name = "";
            last_name = "";
            birth_date = new DateTime();
        }

        public Author(string first_name, string last_name, DateTime birth_date)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.birth_date = birth_date;
        }

        public Author(string value)
        {
            string[] values = value.Split(';');
            this.id = int.Parse(values[0]);
            this.first_name = values[1];
            this.last_name = values[2];
            this.birth_date = Convert.ToDateTime(values[3]);
        }

        public override string to_csv()
        {
            return this.id.ToString() + ";" + this.first_name + ";" + this.last_name + ";" + this.birth_date.ToString();
        }

    }
}
