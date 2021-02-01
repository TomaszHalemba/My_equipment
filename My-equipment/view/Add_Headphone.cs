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
            add_headphone_button.Visible = true;
            modify_item_button.Visible = false;
        }
        public Add_Headphone(int mode)
        {
            InitializeComponent();
            this.mode = mode;

            add_headphone_button.Visible = false;
            modify_item_button.Visible = false;

            if (mode == 0)
            {
                add_headphone_button.Visible = true;
            }
            else
            if (mode == 1)
            {
                modify_item_button.Visible = true;
            }
        }

        private void set_values(Headphone headphone)
        {
            item_id = headphone.id;
            item_name_textbox.Text = headphone.item_name;
            dateTime_bought_picker.Value = headphone.item_bought;
            dateTime_retired_picker.Value = headphone.item_retired;
            price_textbox.Text = headphone.price.ToString();
            description_textbox.Text = headphone.description;
            company_name_textbox.Text = headphone.company_name;
            rating_textbox.Text = headphone.rating.ToString();
            cable_lenght_textbox.Text = headphone.cable_lenght.ToString();
            microphone_checkbox.Checked = headphone.microphone;
            volume_setter_checkbox.Checked = headphone.volume_setter;
            mute_button_checkbox.Checked= headphone.mute_button;
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
        private Headphone Get_headphone_from_form()
        {
            string item_name = item_name_textbox.Text;
            DateTime item_bought = dateTime_bought_picker.Value;
            DateTime item_retired = dateTime_retired_picker.Value;
            float price = float.Parse(price_textbox.Text);
            string description = description_textbox.Text;
            string company_name = company_name_textbox.Text;
            float rating = float.Parse(rating_textbox.Text);
            float cable_lenght = float.Parse(cable_lenght_textbox.Text);
            bool microphone = microphone_checkbox.Checked;
            bool volume_setter = volume_setter_checkbox.Checked;
            bool mute_button = mute_button_checkbox.Checked;

            return new Headphone(new Item(item_name, item_bought, item_retired, price, description, company_name, rating), cable_lenght, microphone, volume_setter, mute_button);
        }

        private void add_headphone_button_Click(object sender, EventArgs e)
        {
            headphone_dao.add_item(Get_headphone_from_form());

        }

        private void Modify_item_button_Click(object sender, EventArgs e)
        {
            headphone_dao.update_item(Get_headphone_from_form());
        }
    }
}
