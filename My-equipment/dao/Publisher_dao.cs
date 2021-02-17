using My_equipment.controler;
using System;
using System.Collections.Generic;
using System.Linq;
using My_equipment.model;
using System.Text;
using System.Threading.Tasks;


namespace My_equipment.dao
{
    class Publisher_dao : interfaces.Item_interface<Publisher>
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
            throw new NotImplementedException();
        }

        public void delete_item(int id)
        {
            throw new NotImplementedException();
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

        public void update_item(Publisher item)
        {
            throw new NotImplementedException();
        }
    }
}
