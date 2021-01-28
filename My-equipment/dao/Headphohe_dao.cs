using My_equipment.interfaces;
using My_equipment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_equipment.dao
{
    class Headphohe_dao : Item_interface<Headphone>
    {
        controler.Database_controller database_Controller;

        public Headphohe_dao()
        {
            database_Controller = new controler.Database_controller();
        }
        private string parseFloatToSql(float value)
        {
            return value.ToString().Replace(",", ".");
        }
        public void add_item(Headphone item)
        {
            string querry;
            querry = "insert into items(item_name , item_bought ,item_retired ,price ,description,company_name,rating) OUTPUT INSERTED.ID values('" +
                item.item_name + "','" +
                item.item_bought.ToString("yyyy-MM-dd") + "','" +
                item.item_retired.ToString("yyyy-MM-dd") + "'," +
                parseFloatToSql(item.price) + ",'" +
                item.description + "','" +
                item.company_name + "'," +
                parseFloatToSql(item.rating) + ") ";

            int item_id =database_Controller.insert_create_delete(querry);

            querry = "insert into Headphones(cable_lenght,microphone,volume_setter,mute_button) OUTPUT INSERTED.ID values(" +
               item.cable_lenght + "," +
               item.microphone + "," +
               item.volume_setter + "," +
               item.mute_button + ")";
            int headphone_id = database_Controller.insert_create_delete(querry);

            querry = "insert into Items_Headphones(Headphone_id, Item_id) values(" +
             headphone_id + "," +
              item_id  + ")";
            database_Controller.insert_create_delete(querry);


        }

        public void delete_item(Headphone item)
        {
            throw new NotImplementedException();
        }

        public void delete_item(int id)
        {
            throw new NotImplementedException();
        }

        public string[] get_header_names(int value)
        {
            throw new NotImplementedException();
        }

        public List<Headphone> get_items()
        {
            throw new NotImplementedException();
        }

        public Headphone get_item_from_row(DataGridViewRow row)
        {
            throw new NotImplementedException();
        }

        public void update_item(Headphone item)
        {
            throw new NotImplementedException();
        }
    }
}
