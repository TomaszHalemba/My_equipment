using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.model
{
    public class Headphone : Item
    {
        public virtual float cable_lenght { get; set; }
        public virtual bool microphone { get; set; }
        public virtual bool volume_setter { get; set; }
        public virtual bool mute_button { get; set; }


        public Headphone() : base()
        {
            cable_lenght = 0;
            microphone = false;
            volume_setter = false;
            mute_button = false;
        }

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
        public Headphone(float cable_lenght, bool microphone, bool volume_setter, bool mute_button) : base()
        {
            this.cable_lenght = cable_lenght;
            this.microphone = microphone;
            this.volume_setter = volume_setter;
            this.mute_button = mute_button;
        }

        public Headphone(string line)
        {
            string[] values = line.Split(';');
            this.id = int.Parse(values[0]);
            this.item_name = values[1];
            this.item_bought = Convert.ToDateTime(values[2]);
            this.item_retired = Convert.ToDateTime(values[3]);
            this.price = float.Parse(values[4]);
            this.description = values[5];
            this.company_name = values[6];
            this.rating = float.Parse(values[7]);

            this.cable_lenght = float.Parse(values[8]);
            this.microphone = Convert.ToBoolean(values[9]);
            this.volume_setter = Convert.ToBoolean(values[10]);
            this.mute_button = Convert.ToBoolean(values[11]);
        }



        public override string to_csv()
        {
            Item item = new Item((Item)this);

            return item.to_csv() + ";" + cable_lenght.ToString() + ";" + microphone.ToString() + ";" + volume_setter.ToString() + ";" + mute_button.ToString();
        }
    }

}
