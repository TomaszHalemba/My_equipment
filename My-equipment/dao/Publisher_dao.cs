using My_equipment.controler;
using System;
using System.Collections.Generic;
using System.Linq;
using My_equipment.model;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_equipment.dao
{
    public class Publisher_dao : interfaces.Item_interface<Publisher>, interfaces.Form_interface<Publisher>
    {
        public void add_item(Publisher item)
        {
            using (var session = Database_controller.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(item);
                    transaction.Commit();
                }
            }
        }

        public void delete_item(Publisher item)
        {
            using (var session = Database_controller.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(item);
                    transaction.Commit();
                }

            }
        }

        public void delete_item(int id)
        {
            using (var session = Database_controller.OpenSession())
            {
                Genre item;

                using (var transaction = session.BeginTransaction())
                {
                    item = (Genre)session.CreateCriteria(typeof(Genre))
                      .List<Genre>().Where(b => b.id == id).ToList().First();
                    session.Delete(item);
                    transaction.Commit();
                }


            }
        }

        public string[] get_header_names(int value)
        {
            string[] names = new string[2];
            if (value == 0)
            {
                names[0] = "Id";
                names[1] = "Wydawca";
            }
            else if (value == 1)
            {
                names[0] = "Id";
                names[1] = "Publisher";

            }
            else
            {
                return get_header_names(0);

            }
            return names;
        }

        public int get_id_column_number()
        {
            return 0;
        }

        public List<Publisher> get_items()
        {
            List<Publisher> publishers = new List<Publisher>();


            using (var session = Database_controller.OpenSession())
            {


                using (session.BeginTransaction())
                {
                    publishers = (List<Publisher>)session.CreateCriteria(typeof(Publisher))
                      .List<Publisher>();
                }
            }


            return publishers;
        }

        public Publisher get_item_from_row(DataGridViewRow row)
        {
            throw new NotImplementedException();
        }

        public void update_item(Publisher item)
        {

            using (var session = Database_controller.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(item);
                    transaction.Commit();
                }
;
            }
        }
    }
}
