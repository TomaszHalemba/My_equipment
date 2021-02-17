using My_equipment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.builders
{
    class Author_builder
    {


        private Author _order = new Author();

        public Author_builder() { }
        public static Author_builder Init(
                                   )
        {
            return new Author_builder();
        }
        public Author Build() => _order;
        public Author_builder Set_first_name(string first_name)
        {
            _order.first_name = first_name;
            return this;
        }
        public Author_builder Set_last_name(string last_name)
        {
            _order.last_name = last_name;
            return this;
        }


    }
}
