using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_equipment.interfaces
{
    interface Form_interface<Class_type>
    {
        string[] get_header_names(int value);
        Class_type get_item_from_row(DataGridViewRow row);

        int get_id_column_number();
    }
}
