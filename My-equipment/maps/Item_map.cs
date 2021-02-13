using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_equipment.model;

namespace My_equipment.maps
{
    public class Item_map : ClassMap<Item>
    {
        public Item_map()
        {
            Id(x => x.id);
            Map(x => x.item_bought);
            Map(x => x.item_retired);
            Map(x => x.price);
            Map(x => x.company_name);
            Map(x => x.description);
            Map(x => x.rating);
            Map(x => x.item_name);

        }
    }
}
