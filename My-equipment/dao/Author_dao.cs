using My_equipment.controler;
using My_equipment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_equipment.dao
{
    public class Author_dao : interfaces.Item_interface<Author>, interfaces.Form_interface<Author>
    {
        public void add_item(Author item)
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

        public void delete_item(Author item)
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
            throw new NotImplementedException();
        }

        public string[] get_header_names(int value)
        {
            throw new NotImplementedException();
        }

        public int get_id_column_number()
        {
            throw new NotImplementedException();
        }

        public List<Author> get_items()
        {
            List<Author> authors = new List<Author>();


            using (var session = Database_controller.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    authors = (List<Author>)session.CreateCriteria(typeof(Author))
                      .List<Author>();
                }
            }


            return authors;
        }

        public Author get_item_from_row(DataGridViewRow row)
        {
            throw new NotImplementedException();
        }

        public void update_item(Author item)
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
