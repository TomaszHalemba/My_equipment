using My_equipment.dao;
using My_equipment.view;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_equipment
{
    public partial class Form1 : Form
    {
        Author_dao author_Dao = new Author_dao();
        Genre_dao genre_Dao = new Genre_dao();
        Publisher_dao publisher_Dao = new Publisher_dao();

        private void set_data_for_show_button_for_utility(ref BindingSource bindingSource, ref string[] header_names)
        {
            if (current_show_index == (int)utility_picker.author)
            {
                bindingSource.DataSource = author_Dao.get_items();
                header_names = author_Dao.get_header_names(0);
            }
            else if (current_show_index == (int)utility_picker.genre)
            {
                bindingSource.DataSource = genre_Dao.get_items();
                header_names = genre_Dao.get_header_names(0);
            }
            else if (current_show_index == (int)utility_picker.publisher)
            {
                bindingSource.DataSource = publisher_Dao.get_items();
                header_names = publisher_Dao.get_header_names(0);
            }


        }

        private void modify_button_for_utility(DataGridViewRow startingBalanceRow)
        {

            if (current_show_index == (int)utility_picker.author)
            {
                model.Author item = this.author_Dao.get_item_from_row(startingBalanceRow);
                Add_author headphones_View = new Add_author(1, item);
                change_panel_content(headphones_View);
            }
            else if (current_show_index == (int)utility_picker.genre)
            {
                model.Genre item = this.genre_Dao.get_item_from_row(startingBalanceRow);
                Add_genre headphones_View = new Add_genre(1, item);
                change_panel_content(headphones_View);
            }
            else if (current_show_index == (int)utility_picker.publisher)
            {
                model.Publisher item = this.publisher_Dao.get_item_from_row(startingBalanceRow);
                Add_publisher headphones_View = new Add_publisher(1, item);
                change_panel_content(headphones_View);
            }

        }

        private void delete_button_for_utility(DataGridViewRow startingBalanceRow)
        {

            if (current_show_index == (int)utility_picker.author)
            {
                this.author_Dao.delete_item((int)startingBalanceRow.Cells[this.author_Dao.get_id_column_number()].Value);

            }

            else
            if (current_show_index == (int)utility_picker.genre)
            {
                this.genre_Dao.delete_item((int)startingBalanceRow.Cells[this.genre_Dao.get_id_column_number()].Value);

            }

            else

            if (current_show_index == (int)utility_picker.publisher)
            {
                this.publisher_Dao.delete_item((int)startingBalanceRow.Cells[this.publisher_Dao.get_id_column_number()].Value);

            }

            else

            {
                MessageBox.Show(resource_manager.GetString("error_category", CultureInfo.CurrentCulture));
            }


        }

        private void add_button_for_utility()
        {
            if (current_show_index == (int)utility_picker.author)
            {
                Add_author headphones_View = new Add_author();
                change_panel_content(headphones_View);
            }
            else if (current_show_index == (int)utility_picker.genre)
            {
                Add_genre headphones_View = new Add_genre();
                change_panel_content(headphones_View);
            }
            else if (current_show_index == (int)utility_picker.publisher)
            {
                Add_publisher headphones_View = new Add_publisher();
                change_panel_content(headphones_View);
            }


        }

    }
}
