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
    public class Genre_dao : interfaces.Item_interface<Genre>, interfaces.Form_interface<Genre>
    {
        public void add_item(Genre item)
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

        public void delete_item(Genre item)
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
                names[1] = "Kategoria";
            }
            else if (value == 1)
            {
                names[0] = "Id";
                names[1] = "Genre";

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

        public List<Genre> get_items()
        {
            List<Genre> genres = new List<Genre>();


            using (var session = Database_controller.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    genres = (List<Genre>)session.CreateCriteria(typeof(Genre))
                      .List<Genre>();
                }
            }
            return genres;
        }

        public Genre get_item_from_row(DataGridViewRow row)
        {
            int id = (int)row.Cells[get_id_column_number()].Value;

            using (var session = Database_controller.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    return session.CreateCriteria<Genre>().Add(Expression.Like("id", id)).SetMaxResults(1).List<Genre>().First();
                }
            }
        }

        public void update_item(Genre item)
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
