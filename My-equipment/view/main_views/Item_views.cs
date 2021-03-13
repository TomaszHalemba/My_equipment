using System;
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
    public partial class Item_views : Form
    {
        class MyStruct
        {
            public string Name { get; set; }
            public string Adres { get; set; }


            public MyStruct(string name, string adress)
            {
                Name = name;
                Adres = adress;
            }
        }
        private BindingSource bindingSource1 = new BindingSource();


        public void set_data_grid_view<class_type>(List<class_type> table_data)
        {
            bindingSource1.DataSource = table_data;
            dataGridView1.DataSource = bindingSource1;
        }
        public Item_views()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
