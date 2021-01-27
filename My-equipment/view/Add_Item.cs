using My_equipment.dao;
using System;
using My_equipment.model;
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
    public partial class Add_Item : Form
    {
        int mode = 0;//0-add 1-modify
        Item_dao item_Dao = new Item_dao();
        int item_id = 0;
        public Add_Item()
        {
            InitializeComponent();
        }
        public Add_Item(int mode)
        {
            InitializeComponent();
            this.mode = mode;

            if (mode == 0)
            {
                add_item_button.Text = "Add item";
            }
            else
            if (mode == 1)
            {
                add_item_button.Text = "Modify item";
            }
        }
        public Add_Item(int mode, Item item)
        {
            InitializeComponent();
            this.mode = mode;

            if (mode == 0)
            {
                add_item_button.Text = "Add item";
            }
            else
            if (mode == 1)
            {
                add_item_button.Text = "Modify item";
                set_values(item);
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

        private void add_item_button_Click(object sender, EventArgs e)
        {
            string item_name = item_name_textbox.Text;
            DateTime item_bought = dateTime_bought_picker.Value;
            DateTime item_retired = dateTime_retired_picker.Value;
            float price = float.Parse(price_textbox.Text);
            string description = description_textbox.Text;
            string company_name = company_name_textbox.Text;
            float rating = float.Parse(rating_textbox.Text);
            if (mode == 0)
            {
                item_Dao.add_item(new Item(item_name, item_bought, item_retired, price, description, company_name, rating));
            }
            else
                if (mode == 1)
            {
                item_Dao.update_item(new Item(item_name, item_bought, item_retired, price, description, company_name, rating,this.item_id));
            }

        }


    }
}
