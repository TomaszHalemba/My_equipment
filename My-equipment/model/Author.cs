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

        public Author(int item_id, string first_name, string last_name, DateTime birth_date)
        {
            this.id = item_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.birth_date = birth_date;
        }

        public virtual bool compare_values(Author author)
        {
            if (this.first_name.Equals(author.first_name) && this.last_name.Equals(author.last_name) && this.birth_date.Equals(author.birth_date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj == System.DBNull.Value)
            {
                return false;
            }
            {
                Author author = (Author)obj;
                if (this.first_name.Equals(author.first_name) && this.last_name.Equals(author.last_name) && this.birth_date.Equals(author.birth_date) && this.id == author.id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           

        }

        public override string ToString()
        {
            return this.first_name + " " + this.last_name + " " + this.birth_date.ToString("MM.dd.yyyy");
        }

        public override string to_csv()
        {
            return this.id.ToString() + ";" + this.first_name + ";" + this.last_name + ";" + this.birth_date.ToString();
        }

    }
}
