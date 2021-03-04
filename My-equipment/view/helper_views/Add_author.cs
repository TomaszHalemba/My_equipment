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
    public partial class Add_author : Form
    {
        int mode = 0;//0-add 1-modify
        Author_dao author_Dao = new Author_dao();
        int item_id = 0;
        public Add_author()
        {
            InitializeComponent();
            add_item_button.Visible = true;
            modify_button.Visible = false;
        }
        public Add_author(int mode)
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
        public Add_author(int mode, Author item)
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

        private void set_values(Author author)
        {
            item_id = author.id;
            first_name_textbox.Text = author.first_name;
            last_name_textbox.Text = author.last_name;

            if (author.birth_date == DateTime.MinValue)
            {
                birth_date_checkbox.Checked = true;
            }
            else
            {
                dateTime_birth_picker.Value = author.birth_date;
                birth_date_checkbox.Checked = false;
            }
        }

        private Author get_item_from_form()
        {
            string first_name=first_name_textbox.Text;
            string last_name=last_name_textbox.Text;
            DateTime birth_date= new DateTime();
            if (!birth_date_checkbox.Checked)
            {
                birth_date = dateTime_birth_picker.Value;
            }
            return new Author(item_id,first_name,last_name,birth_date);
            
        }

        private void add_item_button_Click(object sender, EventArgs e)
        {
 
            author_Dao.add_item(get_item_from_form());
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
           

            author_Dao.update_item(get_item_from_form());
        }
    }
}
