using My_equipment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_equipment.dao
{
    class Item_dao : interfaces.Item_interface<Item>,interfaces.Form_interface<Item>
    {
        controler.Database_controller database_Controller;

        private string parseFloatToSql(float value)
        {
            return value.ToString().Replace(",", ".");
        }
       
        public void add_item(Item item)
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

            database_Controller.insert_create_delete(querry);

        }

        public void delete_item(Item item)
        {
            throw new NotImplementedException();
        }

        public List<Item> get_items()
        {
            List<Item> items = new List<Item>();
            Microsoft.Data.SqlClient.SqlDataReader dreader = database_Controller.select("select item_name,item_bought,item_retired," +
                "price,description,company_name,rating,id from items");


            // for one by one reading row 
            while (dreader.Read())
            {

                string item_name = "";

                DateTime item_bought = new DateTime();
                DateTime item_retired = new DateTime();
                float price = 0;
                string description = "";
                string company_name = "";
                float rating = 0;
                int id = 0;

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
                items.Add(new model.Item(item_name, item_bought, item_retired, price, description, company_name, rating, id));
            }
            database_Controller.disconnect();

            return items;
        }

        public Item get_item_from_row(DataGridViewRow row)
        {
            int id = (int)row.Cells[0].Value;
            string item_name = (string)row.Cells[1].Value;
            DateTime item_bought = (DateTime)row.Cells[2].Value;
            DateTime item_retired = (DateTime)row.Cells[3].Value;
            float price = (float)row.Cells[4].Value;
            string company_name = (string)row.Cells[5].Value;
            float rating = (float)row.Cells[6].Value;
            string description = (string)row.Cells[7].Value;
            return new Item(item_name, item_bought, item_retired, price, description, company_name, rating,id);


        }

        public Item_dao()
        {
            database_Controller = new controler.Database_controller();

        }


        public void delete_item(int id)
        {
            string querry;
            querry = "delete from items where id = " + id.ToString();

            database_Controller.insert_create_delete(querry);
        }

        public void update_item(Item item)
        {
            string querry;
            querry = "update items set item_name='" +
                item.item_name + "',item_bought='" +
                item.item_bought.ToString("yyyy-MM-dd") + "',item_retired='" +
                item.item_retired.ToString("yyyy-MM-dd") + "',price=" +
                parseFloatToSql(item.price) + ",description='" +
                item.description + "',company_name='" +
                item.company_name + "',rating=" +
                parseFloatToSql(item.rating) +
                " where id = " + item.id;

            database_Controller.insert_create_delete(querry);
        }

        public string[] get_header_names(int value)
        {
            string[] names = new string[8];
            if (value == 0)
            {
                names[0] = "Id";
                names[1] = "Nazwa przedmiotu";
                names[2] = "Data zakupu";
                names[3] = "Data zepsucia";
                names[4] = "Cena";
                names[5] = "Nazwa firmy";
                names[6] = "Ocena";
                names[7] = "Opis";
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

            }
            else
            {
                names[0] = "Id";
                names[1] = "Nazwa przedmiotu";
                names[2] = "Data zakupu";
                names[3] = "Data zepsucia";
                names[4] = "Cena";
                names[5] = "Nazwa firmy";
                names[6] = "Ocena";
                names[7] = "Opis";

            }
            return names;
        }

        public int get_id_column_number()
        {
            return 0;
        }
    }
}
