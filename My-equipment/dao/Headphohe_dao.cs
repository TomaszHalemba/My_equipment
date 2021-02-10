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
    class Headphohe_dao : Item_interface<Headphone>, Form_interface<Headphone>
    {
        controler.Database_controller database_Controller;

        public Headphohe_dao()
        {
            database_Controller = new controler.Database_controller();
        }
        private string parse_float_to_sql(float value)
        {
            return value.ToString().Replace(",", ".");
        }
        private int parse_bool_to_sql(bool value)
        {
            if (value == true)
                return 1;
            return 0;
        }
        private int bool_to_int(bool value)
        {
            return value ? 1 : 0;
        }
        public void add_item(Headphone item)
        {
            string querry;
            querry = "insert into items(item_name , item_bought ,item_retired ,price ,description,company_name,rating) OUTPUT INSERTED.ID values('" +
                item.item_name + "','" +
                item.item_bought.ToString("yyyy-MM-dd") + "','" +
                item.item_retired.ToString("yyyy-MM-dd") + "'," +
                parse_float_to_sql(item.price) + ",'" +
                item.description + "','" +
                item.company_name + "'," +
                parse_float_to_sql(item.rating) + ") ";

            int item_id = database_Controller.insert_create_delete_return_id(querry);

            querry = "insert into Headphones(id,cable_lenght,microphone,volume_setter,mute_button) OUTPUT INSERTED.ID values(" +
                item_id.ToString() + "," +
                parse_float_to_sql(item.cable_lenght) + "," +
               bool_to_int(item.microphone) + "," +
                bool_to_int(item.volume_setter) + "," +
                bool_to_int(item.mute_button) + ")";
            int headphone_id = database_Controller.insert_create_delete_return_id(querry);



        }

        public void delete_item(Headphone item)
        {
            throw new NotImplementedException();
        }

        public void delete_item(int id)
        {
            string querry;
            querry = "delete from items where id = " + id.ToString();

            database_Controller.insert_create_delete(querry);
        }

        public string[] get_header_names(int value)
        {
            string[] names = new string[12];
            if (value == 0)
            {
                names[0] = "Długość kabla";
                names[1] = "Mikrofon";
                names[2] = "Sterowanie dźwiękiem";
                names[3] = "Wyłącznik mikrofonu";
                names[4] = "Id";
                names[5] = "Nazwa przedmiotu";
                names[6] = "Data zakupu";
                names[7] = "Data zepsucia";
                names[8] = "Cena";
                names[9] = "Nazwa firmy";
                names[10] = "Ocena";
                names[11] = "Opis";
            }
            else if (value == 1)
            {
                names[0] = "Id";
                names[1] = "Item name";
                names[2] = "Date bought";
                names[3] = "Date retired";
                names[4] = "Price";

                names[5] = "Company name";
                names[6] = "Rating";
                names[7] = "Description";
                names[8] = "Cable lenght";
                names[9] = "Microphone";
                names[10] = "Volume setter";
                names[11] = "Mute button";

            }
            else
            {
                names[0] = "Długość kabla";
                names[1] = "Mikrofon";
                names[2] = "Sterowanie dźwiękiem";
                names[3] = "Wyłącznik mikrofonu";
                names[4] = "Id";
                names[5] = "Nazwa przedmiotu";
                names[6] = "Data zakupu";
                names[7] = "Data zepsucia";
                names[8] = "Cena";
                names[9] = "Nazwa firmy";
                names[10] = "Ocena";
                names[11] = "Opis";

            }
            return names;
        }

        public List<Headphone> get_items(string querry = "select i.id,i.item_name,i.item_bought,i.item_retired," +
            "i.price,i.description,i.company_name,i.rating ,h.cable_lenght,h.microphone,h.volume_setter,h.mute_button from Headphones as h inner join items as i on i.id=h.id")
        {
            List<Headphone> headphones = new List<Headphone>();
            Microsoft.Data.SqlClient.SqlDataReader dreader = database_Controller.select(querry);

            int id = 0;
            float cable_lenght = 0;
            bool microphone = false;
            bool volume_setter = false;
            bool mute_button = false;
            string item_name = "";
            DateTime item_bought = new DateTime();
            DateTime item_retired = new DateTime();
            float price = 0;
            string description = "";
            string company_name = "";
            float rating = 0;


            while (dreader.Read())
            {



                if (dreader.IsDBNull(0) == false)
                {
                    id = dreader.GetInt32(0);

                }
                if (dreader.IsDBNull(1) == false)
                {
                    item_name = (string)dreader.GetValue(1);
                }
                if (dreader.IsDBNull(2) == false)
                {
                    item_bought = dreader.GetDateTime(2);
                }
                if (dreader.IsDBNull(3) == false)
                {
                    item_retired = dreader.GetDateTime(3);
                }
                if (dreader.IsDBNull(4) == false)
                {
                    price = (float)dreader.GetDouble(4);
                }
                if (dreader.IsDBNull(5) == false)
                {
                    description = (string)dreader.GetValue(5);
                }
                if (dreader.IsDBNull(6) == false)
                {
                    company_name = (string)dreader.GetValue(6);
                }
                if (dreader.IsDBNull(7) == false)
                {
                    rating = (float)dreader.GetDouble(7);
                }
                if (dreader.IsDBNull(8) == false)
                {
                    cable_lenght = (float)dreader.GetDouble(8);
                }
                if (dreader.IsDBNull(9) == false)
                {
                    microphone = (bool)dreader.GetSqlBoolean(9);
                }
                if (dreader.IsDBNull(10) == false)
                {
                    volume_setter = (bool)dreader.GetSqlBoolean(10);
                }
                if (dreader.IsDBNull(11) == false)
                {
                    mute_button = (bool)dreader.GetSqlBoolean(11);
                }
                headphones.Add(new Headphone(new model.Item(item_name, item_bought, item_retired, price, description, company_name, rating, id), cable_lenght, microphone, volume_setter, mute_button));
            }
            database_Controller.disconnect();


            return headphones;
        }

        public Headphone get_item_from_row(DataGridViewRow row)
        {

            int id = (int)row.Cells[4].Value;
            float cable_lenght = (float)row.Cells[0].Value;
            bool microphone = (bool)row.Cells[1].Value;
            bool volume_setter = (bool)row.Cells[2].Value;
            bool mute_button = (bool)row.Cells[3].Value;
            string item_name = (string)row.Cells[5].Value;
            DateTime item_bought = (DateTime)row.Cells[6].Value;
            DateTime item_retired = (DateTime)row.Cells[7].Value;
            float price = (float)row.Cells[8].Value;
            string company_name = (string)row.Cells[9].Value;
            float rating = (float)row.Cells[10].Value;
            string description = (string)row.Cells[11].Value;





            return new Headphone(new model.Item(item_name, item_bought, item_retired, price, description, company_name, rating, id), cable_lenght, microphone, volume_setter, mute_button);

        }

        public void update_item(Headphone item)
        {
            string querry;
            querry = "update items set item_name='" +
                item.item_name + "',item_bought='" +
                item.item_bought.ToString("yyyy-MM-dd") + "',item_retired='" +
                item.item_retired.ToString("yyyy-MM-dd") + "',price=" +
                parse_float_to_sql(item.price) + ",description='" +
                item.description + "',company_name='" +
                item.company_name + "',rating=" +
                parse_float_to_sql(item.rating) +
                " where id = " + item.id;

            database_Controller.insert_create_delete(querry);



            querry = "update headphones set cable_lenght=" +
            parse_float_to_sql(item.cable_lenght) + ",microphone=" +
            parse_bool_to_sql(item.microphone) + ",volume_setter=" +
            parse_bool_to_sql(item.volume_setter) + ",mute_button=" +
            parse_bool_to_sql(item.mute_button) +
            " where id = " + item.id;

            database_Controller.insert_create_delete(querry);







        }
        public int get_id_column_number()
        {
            return 4;
        }
    }
}
