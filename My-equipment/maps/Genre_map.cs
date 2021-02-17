using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using My_equipment.model;
using System.Threading.Tasks;

namespace My_equipment.maps
{
    public class Genre_map : ClassMap<Genre>
    {
        public Genre_map()
        {
            Id(x => x.id);
            Map(x => x.name);
            HasMany(x => x.books)
            .Inverse()
            .Not.LazyLoad()
            .Cascade.None()
            .KeyColumn("genre");
        }
    }
}
