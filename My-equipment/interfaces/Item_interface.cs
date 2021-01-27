using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_equipment.model;

namespace My_equipment.interfaces
{
    interface Item_interface
    {
   
         List<Item> get_items();
         void add_item(Item item);
         void delete_item(Item item);
        void delete_item(int id);
        void update_item(Item item);

        string[] get_header_names(int value);
        Item get_item_from_row(DataGridViewRow row);
    }
}
