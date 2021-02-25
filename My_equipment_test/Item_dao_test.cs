using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_equipment.controler;
using My_equipment.dao;

using My_equipment.model;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace My_equipment_test
{
    [TestClass]
    public class Item_dao_test
    {
        Item_dao item_Dao = new Item_dao();
        Headphohe_dao headphone_Dao = new Headphohe_dao();

        [TestInitialize()]
        public void test_initialize()
        {
            Database_controller.set_session_factory(
                Fluently.Configure()
        .Database(
               MsSqlConfiguration.MsSql2012.ConnectionString(@"Server=(localdb)\MSSQLLocalDB;Database=my_equipment_tests;Integrated Security=true;")
              )
              .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<Item>()
                ).ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
              .BuildSessionFactory());


        }

        [TestCleanup()]
        public void test_cleanup()
        {
            item_Dao.get_items().ForEach(c => item_Dao.delete_item(c));
        }

        private bool compare_item_list(List<Item> list_a, List<Item> list_b)
        {

            List<Item> different_items = list_a.Where(list_a_item => !list_b.Contains(list_a_item)).ToList(); ;
            if (different_items.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        [TestMethod]
        public void item_add_works()
        {

            Item item = new Item("tekst", new DateTime(), new DateTime(), 10f, "tmp", "comp", 3f);
            item_Dao.add_item(item);

            Item returned_item = item_Dao.get_items()[0];
            Assert.AreEqual(item,returned_item, "item is wrong");

        }


        [TestMethod]
        public void item_delete_by_id_works()
        {

            Item item = new Item("tekst", new DateTime(), new DateTime(), 10f, "tmp", "comp", 3f);
            item_Dao.add_item(item);
            item_Dao.delete_item(item.id);

            int item_numbers = item_Dao.get_items().Count;
            Assert.AreEqual(0, item_numbers, "delete item by id dont work!");
        }

        [TestMethod]
        public void item_delete_by_object_works()
        {

            Item item = new Item("tekst", new DateTime(), new DateTime(), 10f, "tmp", "comp", 3f);
            item_Dao.add_item(item);
            item_Dao.delete_item(item);

            int item_numbers = item_Dao.get_items().Count;
            Assert.AreEqual(0, item_numbers, "delete item by object dont work!");


        }

        [TestMethod]
        public void item_update_works()
        {

            Item item = new Item("tekst", new DateTime(), new DateTime(), 10f, "tmp", "comp", 3f);
            item_Dao.add_item(item);



            item.item_name = "new name";
            item.company_name = "new company name";
            item.description = "other description";
            item.item_bought = new DateTime(2019, 05, 09);
            item.item_retired = new DateTime(2019, 05, 03);
            item.price = 59.3f;
            item.rating = 1f;

            Item new_item = new Item(item);

            item_Dao.update_item(item);

            Item returned_item = item_Dao.get_items()[0];
            Assert.AreEqual(new_item,returned_item, "item didnt updated");
        }

        [TestMethod]
        public void item_get_only_items_works()
        {

            List<Item> items = new List<Item>{new Item("tekst", new DateTime(), new DateTime(), 10f, "tmp", "comp", 3f),
                new Item("jjjj", new DateTime(), new DateTime(), 1f, "xxx", "yyy", 3f) };
            items.ForEach(w => item_Dao.add_item(w));


            Item item = new Item("new", new DateTime(), new DateTime(), 10f, "jjj", "xxxx", 1f);
            Headphone headphone = new Headphone(item, 10.3f, true, true, true);
            headphone_Dao.add_item(headphone);



            List<Item> returned_items = item_Dao.get_items_only();
            int item_numbers = returned_items.Count;
            Assert.AreEqual(2, item_numbers, "Count dont match!");
            Assert.IsTrue(compare_item_list(items, returned_items), "Items are not correct!");
        }
    }
}
