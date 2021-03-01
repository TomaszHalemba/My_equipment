using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_equipment.controler;
using My_equipment.dao;
using My_equipment.datagrid_classes;
using My_equipment.model;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace My_equipment_test
{
    [TestClass]
    public class Book_dao_test
    {
        Book_dao book_Dao = new Book_dao();
        Genre_dao genre_Dao = new Genre_dao();
        Publisher_dao publisher_Dao = new Publisher_dao();
        Author_dao author_Dao = new Author_dao();

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
            book_Dao.get_items().ForEach(c => book_Dao.delete_item(c));
            genre_Dao.get_items().ForEach(c => genre_Dao.delete_item(c));
            publisher_Dao.get_items().ForEach(c => publisher_Dao.delete_item(c));
            author_Dao.get_items().ForEach(c => author_Dao.delete_item(c));
        }

        private bool compare_item_list(List<Book> list_a, List<Book> list_b)
        {

            List<Book> different_items = list_a.Where(list_a_item => !list_b.Contains(list_a_item)).ToList(); ;
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
        public void book_add_works()
        {
            List<Author> authors = new List<Author> { new Author("im", "naz", new DateTime(1999, 12, 14))};
            Book book = new Book(0, authors, "new_book", new DateTime(1999, 8, 14), new DateTime(1999, 12, 14), new Genre("gen1"), new Publisher("publisher1"), 3f, "new_desc", true);
            book_Dao.add_item(book);

            Book returned_item = book_Dao.get_items()[0];
            Assert.AreEqual(book, returned_item, "item is wrong");

        }


        [TestMethod]
        public void book_get_with_fetch_works()
        {
            List<Author> authors = new List<Author> { new Author("im", "naz", new DateTime(1999, 12, 14)) };
            Book book = new Book(0, authors, "new_book", new DateTime(1999, 8, 14), new DateTime(1999, 12, 14), new Genre("gen1"), new Publisher("publisher1"), 3f, "new_desc", true);
            book_Dao.add_item(book);

            Book returned_item = book_Dao.get_books_with_fetches()[0];
            Assert.AreEqual(book, returned_item, "item is wrong");

        }


        [TestMethod]
        public void book_delete_by_id_works()
        {
            List<Author> authors = new List<Author> { new Author("im", "naz", new DateTime(1999, 12, 14)) };
            Book book = new Book(0, authors, "new_book", new DateTime(1999, 8, 14), new DateTime(1999, 12, 14), new Genre("gen1"), new Publisher("publisher1"), 3f, "new_desc", true);

            book_Dao.add_item(book);
            book_Dao.delete_item(book.id);

            int item_numbers = book_Dao.get_items().Count;
            Assert.AreEqual(0, item_numbers, "delete book by id dont work!");
        }

        [TestMethod]
        public void book_delete_by_object_works()
        {

            List<Author> authors = new List<Author> { new Author("im", "naz", new DateTime(1999, 12, 14)) };
            Book book = new Book(0, authors, "new_book", new DateTime(1999, 8, 14), new DateTime(1999, 12, 14), new Genre("gen1"), new Publisher("publisher1"), 3f, "new_desc", true);

            book_Dao.add_item(book);
            book_Dao.delete_item(book);

            int item_numbers = book_Dao.get_items().Count;
            Assert.AreEqual(0, item_numbers, "delete book by object dont work!");


        }

        [TestMethod]
        public void book_update_works()
        {

            List<Author> authors = new List<Author> { new Author("im", "naz", new DateTime(1999, 12, 14)) };
            Book book = new Book(0, authors, "new_book", new DateTime(1999, 8, 14), new DateTime(1999, 12, 14), new Genre("gen1"), new Publisher("publisher1"), 3f, "new_desc", true);

            book_Dao.add_item(book);



            book.rating = 3f;
            book.book_name = "sss";
            book.date_borrowed = new DateTime(2000, 3, 10);
            book.has_been_readed = false;

            Book new_book = new Book(book);

            book_Dao.update_item(book);

            Book returned_book = book_Dao.get_items()[0];
            Assert.AreEqual(new_book,returned_book, "book didnt updated");
        }

        [TestMethod]
        public void book_update_fetch_works()
        {

            List<Author> authors = new List<Author> { new Author("im", "naz", new DateTime(1999, 12, 14)) };
            Book book = new Book(0, authors, "new_book", new DateTime(1999, 8, 14), new DateTime(1999, 12, 14), new Genre("gen1"), new Publisher("publisher1"), 3f, "new_desc", true);

            book_Dao.add_item(book);



            book.rating = 3f;
            book.book_name = "sss";
            book.date_borrowed = new DateTime(2000, 3, 10);
            book.has_been_readed = false;
            book.genre.name = "tmp";

            Book new_book = new Book(book);

            book_Dao.update_item(book);

            Book returned_book = book_Dao.get_books_with_fetches()[0];
            Assert.AreEqual(new_book, returned_book, "book didnt updated");
        }


        private bool compare_item_list<classType>(List<classType> list_a, List<classType> list_b)
        {

            List<classType> different_items = list_a.Where(list_a_item => !list_b.Contains(list_a_item)).ToList(); ;
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
        public void book_get_books()
        {
            
            List<Author> authors = new List<Author> { new Author("im", "naz", new DateTime(1999, 12, 14)) };
            List<Book> books = new List<Book> { new Book(0, authors, "new_book", new DateTime(1999, 8, 14), new DateTime(1999, 12, 14), new Genre("gen1"), new Publisher("publisher1"), 3f, "new_desc", true),
                 new Book(0, new List<Author> { new Author("im1", "naz1", new DateTime(1999, 12, 14)),new Author("im2", "naz2", new DateTime(1999, 12, 14)) }, "new_book1", new DateTime(1999, 9, 14), new DateTime(1999, 12, 31), new Genre("gen2"), new Publisher("publisher2"), 5f, "new_desc", false)
            };

            books.ForEach(x => book_Dao.add_item(x));



            List<Book_view> view= books.Select(x=> new Book_view (x)).ToList();

            List<Book_view> returned_view = book_Dao.get_books();



            Assert.IsTrue(compare_item_list(view, returned_view), "book didnt updated");
        }
    }
}
