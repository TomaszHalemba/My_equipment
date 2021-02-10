using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_equipment.dao;
using My_equipment.model;
using System.IO;

namespace My_equipment.controler
{
    class Import_export_database
    {

        Item_dao item_Dao = new Item_dao();
        Headphohe_dao headphohe_Dao = new Headphohe_dao();


        private void save_list_to_csv<class_type>(string filename, List<class_type> list) where class_type : Item
        {

            using (StreamWriter sw = File.CreateText(filename))
            {
                foreach (class_type item in list)
                {
                    sw.WriteLine(item.to_csv());
                }
            }

        }
        private void add_all<class_type, class_dao>(List<class_type> list, class_dao dao)
            where class_type : Item
            where class_dao : interfaces.Item_interface<class_type>
        {
            foreach (class_type item in list)
            {
                dao.add_item(item);
            }
        }



        public void export_all()
        {
            save_list_to_csv("items.csv", item_Dao.get_items_only());
            save_list_to_csv("headphones.csv", headphohe_Dao.get_items());
        }

        public void import_all()
        {
            List<Item> items = File.ReadAllLines("items.csv")
                                          .Select(v => new Item(v))
                                          .ToList();
            add_all(items, item_Dao);


            List<Headphone> headphones = File.ReadAllLines("headphones.csv")
                              .Select(v => new Headphone(v))
                              .ToList();

            add_all(headphones, headphohe_Dao);

        }


    }
}
