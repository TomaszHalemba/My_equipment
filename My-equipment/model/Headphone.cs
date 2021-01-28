using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.model
{
    class Headphone :  Item
    {
        public float cable_lenght { get; set; }
        public bool microphone { get; set; }
        public bool volume_setter { get; set; }
        public bool mute_button { get; set; }

        public Headphone(Item item) : base(item)
        {
            this.cable_lenght = 0;
            this.microphone = false;
            this.volume_setter = false;
            this.mute_button = false;
        }
        public Headphone(Item item, float cable_lenght, bool microphone, bool volume_setter, bool mute_button) : base(item)
        {
            this.cable_lenght = cable_lenght;
            this.microphone = microphone;
            this.volume_setter = volume_setter;
            this.mute_button = mute_button;
        }
    }
}
