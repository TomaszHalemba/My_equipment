
using FluentNHibernate.Mapping;
using My_equipment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.maps
{

    public class Headphone_map : SubclassMap<Headphone>
    {
        public Headphone_map()
        {
            Map(x => x.cable_lenght);
            Map(x => x.microphone);
            Map(x => x.volume_setter);
            Map(x => x.mute_button);
            KeyColumn("id");
        }
    }

}
