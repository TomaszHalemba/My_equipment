using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.model
{
    public class Genre : Generic_entity
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual IList<Book> books { get; protected set; }

        public Genre() { }
        public Genre(string name)
        {
            this.name = name;
        }
        public Genre(int id)
        {
            this.id = id;
        }
        public Genre(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        public override string to_csv()
        {
            return this.id.ToString() + ";" + this.name;
        }

        public override bool Equals(object obj)
        {
            Genre genre = (Genre)obj;
            if (
                this.id == genre.id &&
                this.name == genre.name
                )
            {
                return true;
            }
            else return false;
        }

    }
}
