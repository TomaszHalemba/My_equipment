using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using My_equipment.model;

namespace My_equipment.maps
{
    class Publisher_map : ClassMap<Publisher>
    {
        public Publisher_map()
        {
            Id(x => x.id);
            Map(x => x.name);
            HasMany(x => x.books)
            .Inverse()
            .Not.LazyLoad()
            .Cascade.None()
            .KeyColumn("publisher");
        }
    }
}
