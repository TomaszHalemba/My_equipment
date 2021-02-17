using My_equipment.controler;
using My_equipment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.dao
{
    class Genre_dao : interfaces.Item_interface<Genre>
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
            throw new NotImplementedException();
        }

        public void delete_item(int id)
        {
            throw new NotImplementedException();
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

        public void update_item(Genre item)
        {
            throw new NotImplementedException();
        }
    }
}
