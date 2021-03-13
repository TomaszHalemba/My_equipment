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


        private  void  set_data_for_show_button_for_items(ref BindingSource bindingSource, ref string [] header_names)
        {
            if (current_show_index == (int)item_picker.item)
            {

                //tmp = await item_Dao.get_items1();
                header_names = item_Dao.get_header_names(0);
                bindingSource.DataSource = item_Dao.get_items();

                    

            }

            else if (current_show_index == (int)item_picker.headphone)
            {
                bindingSource.DataSource = headphohe_Dao.get_items();
                header_names = headphohe_Dao.get_header_names(0);
            }

            else if (current_show_index == (int)item_picker.book)
            {
                bindingSource.DataSource = book_dao.get_books();
                header_names = book_dao.get_header_names(0);
            }
            else
            {
                bindingSource.DataSource = item_Dao.get_items();
                header_names = item_Dao.get_header_names(0);
            }
            //bindingSource.DataSource = tmp;
        }

        private void modify_button_for_items(DataGridViewRow startingBalanceRow)
        {

            if (current_show_index == (int)item_picker.item)
            {
                model.Item item = this.item_Dao.get_item_from_row(startingBalanceRow);
                Add_Item headphones_View = new Add_Item(1, item);
                change_panel_content(headphones_View);

            }

            else if (current_show_index == (int)item_picker.headphone)
            {
                model.Headphone item = this.headphohe_Dao.get_item_from_row(startingBalanceRow);
                Add_Headphone headphones_View = new Add_Headphone(1, item);
                change_panel_content(headphones_View);
            }
            else if (current_show_index == (int)item_picker.book)
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

        private void delete_button_for_items(DataGridViewRow startingBalanceRow)
        {

            if (current_show_index == (int)item_picker.item)
            {
                this.item_Dao.delete_item((int)startingBalanceRow.Cells[this.item_Dao.get_id_column_number()].Value);

            }
            else if (current_show_index == (int)item_picker.headphone)
            {
                this.headphohe_Dao.delete_item((int)startingBalanceRow.Cells[this.headphohe_Dao.get_id_column_number()].Value);
            }
            else if (current_show_index == (int)item_picker.book)
            {
                this.book_dao.delete_item((int)startingBalanceRow.Cells[this.book_dao.get_id_column_number()].Value);
            }
            else
            {
                MessageBox.Show(resource_manager.GetString("error_category", CultureInfo.CurrentCulture));
            }


        }

        private void add_button_for_items()
        {
            if (current_show_index == (int)item_picker.item)
            {

                Add_Item headphones_View = new Add_Item();
                change_panel_content(headphones_View);
            }
            else if (current_show_index == (int)item_picker.headphone)
            {

                Add_Headphone headphones_View = new Add_Headphone();
                change_panel_content(headphones_View);
            }

            else if (current_show_index == (int)item_picker.book)
            {

                Add_book headphones_View = new Add_book();
                change_panel_content(headphones_View);
            }
        }

    }
}
