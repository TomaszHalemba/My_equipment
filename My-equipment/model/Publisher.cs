using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.model
{
    public class Publisher : Generic_entity
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual IList<Book> books { get; protected set; }

        public Publisher() { }
        public Publisher(string name)
        {
            this.name = name;

        }
        public Publisher(int id)
        {
            this.id = id;
        }
        public Publisher(int id, string name)
        {
            this.id = id;
            this.name = name;

        }

        public override bool Equals(object obj)
        {
            Publisher publisher = (Publisher)obj;
            if (
                this.id == publisher.id &&
                this.name == publisher.name
                )
            {
                return true;
            }
            else return false;
        }
        public override string to_csv()
        {
            return this.id.ToString() + ";" + this.name;
        }
    }
}
