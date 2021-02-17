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


        private readonly int item_index = 0;
        private readonly int headphone_index = 1;
        private const int book_index = 2;
        private int current_show_index = 0;





      

        public Form1()
        {
            InitializeComponent();
            Category_combobox.SelectedIndex = 0;

            //List<Author> authors = new List<Author> { new Author("firstN1", "lastN1", new DateTime()), new Author("firstN2", "lastN2", new DateTime()) };
            ////Book item = new Book(3, authors, "test1234", new DateTime(), new DateTime(), new Genre("Fantasty"), new Publisher("Zombie"), 9f, "opis", false);

            //Book item = book_dao.get_items()[0];

            ////item.genre = new Genre("YYY");
            //item.book_name = "jjj";
            //item.publisher.name = "xxx";
            //////item.id = 0;
            //item.authors[0].first_name = "aaa";

            //using (var session = Database_controller.OpenSession())
            //{


            //    using (var transaction = session.BeginTransaction())
            //    {
            //        session.SaveOrUpdate(item);
            //        transaction.Commit();
            //    }
            //}



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
            if (current_show_index == item_index)
            {

                Add_Item headphones_View = new Add_Item();
                change_panel_content(headphones_View);
            }
            else if (current_show_index == headphone_index)
            {

                Add_Headphone headphones_View = new Add_Headphone();
                change_panel_content(headphones_View);
            }

            else if (current_show_index == book_index)
            {

                Add_book headphones_View = new Add_book();
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
            current_show_index = Category_combobox.SelectedIndex;


            if (current_show_index == item_index)
            {
                bindingSource1.DataSource = item_Dao.get_items();
                header_names = item_Dao.get_header_names(0);


            }

            else if (current_show_index == headphone_index)
            {
                bindingSource1.DataSource = headphohe_Dao.get_items();
                header_names = headphohe_Dao.get_header_names(0);
            }

            else if (current_show_index == book_index)
            {
                bindingSource1.DataSource = book_dao.get_books();
                header_names = book_dao.get_header_names(0);
            }
            else
            {
                bindingSource1.DataSource = item_Dao.get_items();
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


            panel = (DataGridView)this.Controls.Find("dataGridView1", true)[0];
            DataGridViewRow startingBalanceRow = panel.Rows[panel.CurrentCell.RowIndex];


            if (current_show_index == item_index)
            {
                Item item = this.item_Dao.get_item_from_row(startingBalanceRow);
                Add_Item headphones_View = new Add_Item(1, item);
                change_panel_content(headphones_View);

            }

            else if (current_show_index == headphone_index)
            {
                model.Headphone item = this.headphohe_Dao.get_item_from_row(startingBalanceRow);
                Add_Headphone headphones_View = new Add_Headphone(1, item);
                change_panel_content(headphones_View);
            }
            else if (current_show_index == book_index)
            {
                model.Book item = book_dao.get_item_from_row(startingBalanceRow);
                Add_book headphones_View = new Add_book(1, item);
                change_panel_content(headphones_View);
            }
            else
            {
                MessageBox.Show(resource_manager.GetString("error_category", CultureInfo.CurrentCulture));
            }






        }

        private void delete_button_Click(object sender, EventArgs e)
        {



            panel = (DataGridView)this.Controls.Find("dataGridView1", true)[0];
            DataGridViewRow startingBalanceRow = panel.Rows[panel.CurrentCell.RowIndex];


            if (current_show_index == item_index)
            {
                this.item_Dao.delete_item((int)startingBalanceRow.Cells[this.item_Dao.get_id_column_number()].Value);

            }

            else if (current_show_index == headphone_index)
            {
                this.headphohe_Dao.delete_item((int)startingBalanceRow.Cells[this.headphohe_Dao.get_id_column_number()].Value);
            }
            else if (current_show_index == book_index)
            {
                this.book_dao.delete_item((int)startingBalanceRow.Cells[this.book_dao.get_id_column_number()].Value);
            }
            else
            {
                MessageBox.Show(resource_manager.GetString("error_category", CultureInfo.CurrentCulture));
            }



            show_button_Click(sender, e);

        }




        private void Category_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
