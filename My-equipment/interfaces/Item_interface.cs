using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_equipment.model;

namespace My_equipment.interfaces
{
    interface Item_interface<Class_type>
    {

        List<Class_type> get_items(string querry = "");
        void add_item(Class_type item);
        void delete_item(Class_type item);
        void delete_item(int id);
        void update_item(Class_type item);


    }
}
