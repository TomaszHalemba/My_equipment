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
    class Author_dao : interfaces.Item_interface<Author>
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
            throw new NotImplementedException();
        }

        public void delete_item(int id)
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

        public void update_item(Author item)
        {
            throw new NotImplementedException();
        }
    }
}
