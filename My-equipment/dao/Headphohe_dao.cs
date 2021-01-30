﻿using My_equipment.interfaces;
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
                parseFloatToSql(item.price) + ",'" +
                item.description + "','" +
                item.company_name + "'," +
                parseFloatToSql(item.rating) + ") ";

            int item_id = database_Controller.insert_create_delete_return_id(querry);

            querry = "insert into Headphones(cable_lenght,microphone,volume_setter,mute_button) OUTPUT INSERTED.ID values(" +
                parseFloatToSql(item.cable_lenght) + "," +
               bool_to_int(item.microphone) + "," +
                bool_to_int(item.volume_setter) + "," +
                bool_to_int(item.mute_button) + ")";
            int headphone_id = database_Controller.insert_create_delete_return_id(querry);

            querry = "insert into Items_Headphones(Headphone_id, Item_id) values(" +
             headphone_id.ToString() + "," +
              item_id.ToString() + ")";
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

        public List<Headphone> get_items()
        {
            List<Headphone> headphones = new List<Headphone>();
            List<Item> items = new List<Item>();
            List<int> headphones_id = new List<int>();
            Microsoft.Data.SqlClient.SqlDataReader dreader = database_Controller.select("select id,cable_lenght,microphone,volume_setter,mute_button from Headphones");

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
                    headphones_id.Add(id);
                }
                if (dreader.IsDBNull(1) == false)
                {
                    cable_lenght = (float)dreader.GetDouble(1);
                }
                if (dreader.IsDBNull(2) == false)
                {
                    microphone = (bool)dreader.GetSqlBoolean(2);
                }
                if (dreader.IsDBNull(3) == false)
                {
                    volume_setter = (bool)dreader.GetSqlBoolean(3);
                }
                if (dreader.IsDBNull(4) == false)
                {
                    mute_button = (bool)dreader.GetSqlBoolean(4);
                }
                headphones.Add(new Headphone(cable_lenght, microphone, volume_setter, mute_button));
            }
            database_Controller.disconnect();
            dreader = database_Controller.select("select item_name,item_bought,item_retired," +
            "price,description,company_name,rating,id from  items as i inner join Items_Headphones as ih on i.id=ih.Item_id where ih.Headphone_id in (" + string.Join(",", headphones_id) + ")");

            int a = 0;
            while (dreader.Read())
            {
                if (dreader.IsDBNull(0) == false)
                {
                    item_name = (string)dreader.GetValue(0);
                }
                if (dreader.IsDBNull(1) == false)
                {
                    item_bought = dreader.GetDateTime(1);
                }
                if (dreader.IsDBNull(2) == false)
                {
                    item_retired = dreader.GetDateTime(2);
                }
                if (dreader.IsDBNull(3) == false)
                {
                    price = (float)dreader.GetDouble(3);
                }
                if (dreader.IsDBNull(4) == false)
                {
                    description = (string)dreader.GetValue(4);
                }
                if (dreader.IsDBNull(5) == false)
                {
                    company_name = (string)dreader.GetValue(5);
                }
                if (dreader.IsDBNull(6) == false)
                {
                    rating = (float)dreader.GetDouble(6);
                }
                if (dreader.IsDBNull(7) == false)
                {
                    id = dreader.GetInt32(7);
                }
                headphones[a].setItemValues(new model.Item(item_name, item_bought, item_retired, price, description, company_name, rating, id));

            }



            database_Controller.disconnect();

            return headphones;
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
