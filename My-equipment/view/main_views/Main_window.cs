using My_equipment.controler;
using My_equipment.dao;
using My_equipment.model;
using My_equipment.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentNHibernate;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using System.Threading;

namespace My_equipment
{
    public partial class Form1 : Form
    {

        DataGridView panel;
        Item_dao item_Dao = new Item_dao();
        Headphohe_dao headphohe_Dao = new Headphohe_dao();
        Book_dao book_dao = new Book_dao();
        Import_export_database import_Export_Database = new Import_export_database();
        ResourceManager resource_manager = new ResourceManager("My_equipment.resources.en", Assembly.GetExecutingAssembly());


        private int current_show_index = 0;
        private int current_category_for_tables = 0;

        enum tables_picker { Items, Utility }

        enum item_picker { item, headphone, book };
        enum utility_picker { author, genre, publisher }




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


        private void set_panel_header_names(DataGridView panel, string[] name_tables)
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
            current_show_index = Category_combobox.SelectedIndex;
            if (current_category_for_tables == (int)tables_picker.Items)
            {
                add_button_for_items();
            }
            else if (current_category_for_tables == (int)tables_picker.Utility)
            {
                add_button_for_utility();
            }

        }



        private void show_button_Click(object sender, EventArgs e)
        {


            Item_views headphones_View = new Item_views();
            change_panel_content(headphones_View);
            current_show_index = Category_combobox.SelectedIndex;
            panel = (DataGridView)this.Controls.Find("dataGridView1", true)[0];
            BindingSource bindingSource1 = new BindingSource();

            string[] header_names = null;
            Thread thr = new Thread(() =>
            {

                if (current_category_for_tables == (int)tables_picker.Items)
                {

                    set_data_for_show_button_for_items(ref bindingSource1, ref header_names);

                }
                else if (current_category_for_tables == (int)tables_picker.Utility)
                {
                    set_data_for_show_button_for_utility(ref bindingSource1, ref header_names);
                }

                panel.Invoke(new Action(() =>
                {
                    panel.DataSource = bindingSource1;
                    set_panel_header_names(panel, header_names);
                }));
            });
            thr.Start();





            panel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            panel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            panel.AllowUserToOrderColumns = true;
            panel.AllowUserToResizeColumns = true;






        }

        private void modiffy_button_Click(object sender, EventArgs e)
        {


            panel = (DataGridView)this.Controls.Find("dataGridView1", true)[0];
            DataGridViewRow startingBalanceRow = panel.Rows[panel.CurrentCell.RowIndex];


            if (current_category_for_tables == (int)tables_picker.Items)
            {
                modify_button_for_items(startingBalanceRow);

            }
            else if (current_category_for_tables == (int)tables_picker.Utility)
            {
                modify_button_for_utility(startingBalanceRow);
            }



        }

        private void delete_button_Click(object sender, EventArgs e)
        {



            panel = (DataGridView)this.Controls.Find("dataGridView1", true)[0];
            DataGridViewRow startingBalanceRow = panel.Rows[panel.CurrentCell.RowIndex];




            if (current_category_for_tables == (int)tables_picker.Items)
            {
                delete_button_for_items(startingBalanceRow);

            }
            else if (current_category_for_tables == (int)tables_picker.Utility)
            {
                delete_button_for_utility(startingBalanceRow);
            }



            show_button_Click(sender, e);

        }


        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            import_Export_Database.export_all();
            MessageBox.Show(resource_manager.GetString("exported_ok", CultureInfo.CurrentCulture));
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            import_Export_Database.import_all();
            MessageBox.Show(resource_manager.GetString("imported_ok", CultureInfo.CurrentCulture));
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current_category_for_tables = 0;
            Category_combobox.Items.Clear();
            Category_combobox.Items.Add("Items");
            Category_combobox.Items.Add("Headphones");
            Category_combobox.Items.Add("Books");
            Category_combobox.SelectedIndex = 0;
        }

        private void utilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current_category_for_tables = 1;
            Category_combobox.Items.Clear();

            Category_combobox.Items.Add("Authors");
            Category_combobox.Items.Add("Genre");
            Category_combobox.Items.Add("Publisher");
            Category_combobox.SelectedIndex = 0;
        }
    }
}
