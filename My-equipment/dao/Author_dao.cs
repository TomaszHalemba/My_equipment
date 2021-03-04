using My_equipment.controler;
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
            using(var session = Database_controller.OpenSession())
            {
                Author item;

                using (var transaction = session.BeginTransaction())
                {
                    item = (Author)session.CreateCriteria(typeof(Author))
                      .List<Author>().Where(b => b.id == id).ToList().First();
                    session.Delete(item);
                    transaction.Commit();
                }


            }
        }

        public string[] get_header_names(int value)
        {
            string[] names = new string[4];
            if (value == 0)
            {
                names[0] = "Id";
                names[1] = "Imie";
                names[2] = "Nazwisko";
                names[3] = "Data urodzenia";
            }
            else if (value == 1)
            {
                names[0] = "Id";
                names[1] = "First name";
                names[2] = "Last name";
                names[3] = "Birth date";

            }
            else
            {
                names[0] = "Id";
                names[1] = "Imie";
                names[2] = "Nazwisko";
                names[3] = "Data urodzenia";

            }
            return names;
        }

        public int get_id_column_number()
        {
            return 0;
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
            int id = (int)row.Cells[get_id_column_number()].Value;

            using (var session = Database_controller.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    return session.CreateCriteria<Author>().Add(Expression.Like("id", id)).SetMaxResults(1).List<Author>().First();
                }
            }
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
