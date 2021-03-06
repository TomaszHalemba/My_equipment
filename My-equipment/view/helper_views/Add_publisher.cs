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
    public partial class Add_publisher : Form
    {
        int mode = 0;//0-add 1-modify
        Genre_dao genre_Dao = new Genre_dao();
        int item_id = 0;
        public Add_publisher()
        {
            InitializeComponent();
            add_item_button.Visible = true;
            modify_button.Visible = false;
        }
        public Add_publisher(int mode)
        {
            InitializeComponent();
            this.mode = mode;
            add_item_button.Visible = false;
            modify_button.Visible = false;

            if (mode == 0)
            {
                add_item_button.Visible = true;
            }
            else
            if (mode == 1)
            {
                modify_button.Visible = true;
            }
        }
        public Add_publisher(int mode, Publisher item)
        {
            InitializeComponent();
            add_item_button.Visible = false;
            modify_button.Visible = false;

            if (mode == 0)
            {
                add_item_button.Visible = true;
            }
            else
            if (mode == 1)
            {
                modify_button.Visible = true;
                set_values(item);
            }
        }

        private void set_values(Publisher genre)
        {
            item_id = genre.id;
            publisher_textbox.Text = genre.name;
   
        }

        private Genre get_item_from_form()
        {
            string genre=publisher_textbox.Text;
           
            return new Genre(item_id,genre);
            
        }

        private void add_item_button_Click(object sender, EventArgs e)
        {
 
            genre_Dao.add_item(get_item_from_form());
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
           

            genre_Dao.update_item(get_item_from_form());
        }
    }
}
