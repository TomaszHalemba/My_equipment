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
        public Form1()
        {
            InitializeComponent();
            
        }

        Item_dao item_Dao = new Item_dao();

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


            panel1.Controls.Clear();
            Add_Item headphones_View = new Add_Item();
            headphones_View.TopLevel = false;
            panel1.Controls.Add(headphones_View);
            headphones_View.Show();
            





        }

        private void show_button_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            Item_views headphones_View = new Item_views();
            headphones_View.TopLevel = false;
            panel1.Controls.Add(headphones_View);
            headphones_View.Show();


            panel = (DataGridView)this.Controls.Find("dataGridView1", true)[0];
            BindingSource bindingSource1 = new BindingSource();
            List<model.Item> table = item_Dao.get_items();
            string[] header_names = item_Dao.get_header_names(0);
            bindingSource1.DataSource = table;
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

            panel1.Controls.Clear();
            Add_Item headphones_View = new Add_Item(1, item);
            headphones_View.TopLevel = false;
            panel1.Controls.Add(headphones_View);
            headphones_View.Show();



                
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            panel = (DataGridView)this.Controls.Find("dataGridView1", true)[0];
            DataGridViewRow startingBalanceRow = panel.Rows[panel.CurrentCell.RowIndex];
            this.item_Dao.delete_item((int)startingBalanceRow.Cells[0].Value);
            show_button_Click(sender, e);
        }
    }
}
