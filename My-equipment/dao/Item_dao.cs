using My_equipment.model;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_equipment.dao
{
    class Item_dao : interfaces.Item_interface<Item>, interfaces.Form_interface<Item>
    {
        controler.Database_controller database_Controller;



        private string parseFloatToSql(float value)
        {
            return value.ToString().Replace(",", ".");
        }

        public void add_item(Item item)
        {


            using (var session = database_Controller.sessionFactory.OpenSession())
            {


                using (var transaction = session.BeginTransaction())
                {
                    session.Save(item);
                    transaction.Commit();
                }
            }


        }

        public void delete_item(Item item)
        {
            using (var session = database_Controller.sessionFactory.OpenSession())
            {
              
                session.Delete(item);
                session.Flush();

            }
        }

        public List<Item> get_items_only()
        {
            List<Item> items = new List<Item>();



            using (var session = database_Controller.sessionFactory.OpenSession())
            {
                items = session.Query<Item>()
        .Where(c=> !(session.Query<Headphone>().Select(x => x.id)).Contains(c.id)  )
        .ToList();


            }


            return items;

        }

        public List<Item> get_items()
        {
            List<Item> items = new List<Item>();


            using (var session = database_Controller.sessionFactory.OpenSession())
            {


                using (session.BeginTransaction())
                {
                    items = (List<Item>)session.CreateCriteria(typeof(Item))
                      .List<Item>();
                }
            }


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
            return new Item(item_name, item_bought, item_retired, price, description, company_name, rating, id);


        }

        public Item_dao()
        {
            database_Controller = new controler.Database_controller();

        }


        public void delete_item(int id)
        {

            using (var session = database_Controller.sessionFactory.OpenSession())
            {


                using (var transaction = session.BeginTransaction())
                {
                    var queryString = string.Format("delete Item where id = :id");
                    session.CreateQuery(queryString)
                           .SetParameter("id", id)
                           .ExecuteUpdate();

                    transaction.Commit();
                }


            }
        }

        public void update_item(Item item)
        {

            using (var session = database_Controller.sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(item);
                    transaction.Commit();
                }
;
            }
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
