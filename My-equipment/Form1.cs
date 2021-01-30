using My_equipment.controler;
using My_equipment.dao;
using My_equipment.model;
using My_equipment.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_equipment
{
    public partial class Form1 : Form
    {
        DataGridView panel;
        Item_dao item_Dao = new Item_dao();
        Headphohe_dao headphohe_Dao = new Headphohe_dao();


        public Form1()
        {
            InitializeComponent();
            Category_combobox.SelectedIndex = 0;
            
        }

        private void change_panel_content<T>(T new_content) where T : Form
        {

            panel1.Controls.Clear();
            new_content.TopLevel = false;
            panel1.Controls.Add(new_content);
            new_content.Show();
        }
        

        private void set_panel_header_names(DataGridView panel,string[] name_tables)
        {
            int a = 0;
            foreach (string name in name_tables)
            {
               
                panel.Columns[a].HeaderText = name;
                a++;
            }
        }
        


        private void add_button_Click(object sender, EventArgs e)
        {
            if (Category_combobox.SelectedItem.ToString().Equals("Items"))
            {
                Add_Item headphones_View = new Add_Item();
                change_panel_content(headphones_View);
            }
            else if (Category_combobox.SelectedItem.ToString().Equals("Headphones"))
            {

                Add_Headphone headphones_View = new Add_Headphone();
                change_panel_content(headphones_View);
            }

            





        }

        private void show_button_Click(object sender, EventArgs e)
        {
            
            Item_views headphones_View = new Item_views();
            change_panel_content(headphones_View);
            panel = (DataGridView)this.Controls.Find("dataGridView1", true)[0];
            BindingSource bindingSource1 = new BindingSource();

            string[] header_names;



            if (Category_combobox.SelectedItem.ToString().Equals("Items"))
            {
                bindingSource1.DataSource  = item_Dao.get_items();
                header_names = item_Dao.get_header_names(0);

            }

            else if (Category_combobox.SelectedItem.ToString().Equals("Headphones"))
            {
                bindingSource1.DataSource  = headphohe_Dao.get_items();
                header_names = headphohe_Dao.get_header_names(0);
            }
            else
            {
                bindingSource1.DataSource  = item_Dao.get_items();
                header_names = item_Dao.get_header_names(0);
            }
            
            panel.DataSource = bindingSource1;
            set_panel_header_names(panel, header_names);
            panel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            panel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            panel.AllowUserToOrderColumns = true;
            panel.AllowUserToResizeColumns = true;



        }

        private void modiffy_button_Click(object sender, EventArgs e)
        {
            //ustawić dane w item view, i przycisk zmienić, ustawić skąd on pochodzi

            panel = (DataGridView)this.Controls.Find("dataGridView1", true)[0];
            DataGridViewRow startingBalanceRow = panel.Rows[panel.CurrentCell.RowIndex];

            Item item = this.item_Dao.get_item_from_row(startingBalanceRow);



            Add_Item headphones_View = new Add_Item(1, item);
            change_panel_content(headphones_View);




                
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            panel = (DataGridView)this.Controls.Find("dataGridView1", true)[0];
            DataGridViewRow startingBalanceRow = panel.Rows[panel.CurrentCell.RowIndex];
            this.item_Dao.delete_item((int)startingBalanceRow.Cells[0].Value);
            show_button_Click(sender, e);
        }

        private void Create_database_button_Click(object sender, EventArgs e)
        {
            Database_controller database = new Database_controller();
            database.createDatabase();
        }
    }
}
