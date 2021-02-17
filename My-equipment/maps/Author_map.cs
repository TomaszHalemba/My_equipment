using FluentNHibernate.Mapping;
using My_equipment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.maps
{
    public class Author_map : ClassMap<Author>
    {
        public Author_map()
        {
            Id(x => x.id, "Author_id");
            Map(x => x.first_name);
            Map(x => x.last_name);
            Map(x => x.birth_date);

            HasManyToMany(x => x.books).Table("Book_Author").Cascade.SaveUpdate().Not.LazyLoad().Inverse()
                .ParentKeyColumn("Author_id")
                .ChildKeyColumn("Book_id");

        }
    }
}
