using My_equipment.dao;
using My_equipment.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_equipment.view
{
    public partial class Add_Headphone : Form
    {
        int mode = 0;//0-add 1-modify
        Headphohe_dao headphone_dao = new Headphohe_dao();
        int item_id = 0;
        public Add_Headphone()
        {
            InitializeComponent();
        }
        public Add_Headphone(int mode)
        {
            InitializeComponent();
            this.mode = mode;

            if (mode == 0)
            {
                add_headphone_button.Text = "Add item";
            }
            else
            if (mode == 1)
            {
                add_headphone_button.Text = "Modify item";
            }
        }

        private void set_values(Item item)
        {
            item_id = item.id;
            item_name_textbox.Text = item.item_name;
            dateTime_bought_picker.Value = item.item_bought;
            dateTime_retired_picker.Value = item.item_retired;
            price_textbox.Text = item.price.ToString();
            description_textbox.Text = item.description;
            company_name_textbox.Text = item.company_name;
            rating_textbox.Text = item.rating.ToString();
        }

        public Add_Headphone(int mode, Headphone item)
        {
            InitializeComponent();
            this.mode = mode;

            if (mode == 0)
            {
                add_headphone_button.Text = "Add item";
            }
            else
            if (mode == 1)
            {
                add_headphone_button.Text = "Modify item";
                set_values(item);
            }
        }

        private void add_headphone_button_Click(object sender, EventArgs e)
        {
            string item_name = item_name_textbox.Text;
            DateTime item_bought = dateTime_bought_picker.Value;
            DateTime item_retired = dateTime_retired_picker.Value;
            float price = float.Parse(price_textbox.Text);
            string description = description_textbox.Text;
            string company_name = company_name_textbox.Text;
            float rating = float.Parse(rating_textbox.Text);
            float cable_lenght = float.Parse(cable_lenght_textbox.Text);
            bool microphone = Microphone_checkbox.Checked;
            bool volume_setter = Volume_setter_checkbox.Checked;
            bool mute_button = Mute_button_checkbox.Checked;
            if (mode == 0)
            {
                headphone_dao.add_item(new Headphone(new Item(item_name, item_bought, item_retired, price, description, company_name, rating), cable_lenght, microphone, volume_setter, mute_button));
            }
            else
                if (mode == 1)
            {
                headphone_dao.update_item(new Headphone(new Item(item_name, item_bought, item_retired, price, description, company_name, rating, this.item_id),cable_lenght,microphone,volume_setter,mute_button));
            }
        }
    }
}
