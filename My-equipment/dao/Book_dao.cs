using My_equipment.model;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_equipment.controler;
using My_equipment.interfaces;
using System.Collections;
using My_equipment.datagrid_classes;
using NHibernate;
using NHibernate.Transform;

namespace My_equipment.dao
{
    public class Book_dao : interfaces.Item_interface<Book>, interfaces.Form_interface<Book>
    {



        public void add_item(Book item)
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

        public void delete_item(Book item)
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

        public List<Book> get_books_with_fetches()
        {
            using (var session = Database_controller.OpenSession())
            {


                using (var tx = session.BeginTransaction())
                {
                    return (List<Book>)session.QueryOver<Book>()
                        .Fetch(x => x.authors).Eager
                        .Fetch(x => x.publisher).Eager
                        .Fetch(x => x.genre).Eager
                      .List<Book>();

                    tx.Commit();
                }
            }
        }



        public List<Book_view> get_books()
        {
            List<Book> items = new List<Book>();
            using (var session = Database_controller.OpenSession())
            {

                using (session.BeginTransaction())
                {
                    items = (List<Book>)session.QueryOver<Book>()

                        .Fetch(SelectMode.Fetch, c => c.authors)
                        .Fetch(SelectMode.FetchLazyProperties, x => x.publisher)
                        .Fetch(SelectMode.FetchLazyProperties, x => x.genre)
                        .TransformUsing(Transformers.DistinctRootEntity)
                        .List<Book>();


                }
            }

            List<Book_view> book_querry = items.Select(x => new Book_view(x.id, x.book_name, String.Join(";", x.authors.Select(m => m.first_name + " " + m.last_name).ToArray()), x.date_borrowed, x.date_returned, x.description, x.rating, x.genre.name, x.publisher.name, x.has_been_readed)).ToList();

            //List<Book_view> book_querry = from book in items
            //                           let authors_string = String.Join(";", book.authors.Select(m => m.first_name + " " + m.last_name).ToArray())

            //                           select new { book.id, book.book_name, authors_string, book.date_borrowed, book.date_returned, book.description,book.rating, genre = book.genre.name, publisher = book.publisher.name,book.has_been_readed };
            //new ClearBook {
            //    Code = x.Code, Book = x.Book}).ToList();



            return book_querry;
        }


        public Book get_item_from_row(DataGridViewRow row)
        {

            int id = (int)row.Cells[get_id_column_number()].Value;

            using (var session = Database_controller.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    return session.CreateCriteria<Book>().Add(Expression.Like("id", id)).SetMaxResults(1).List<Book>().First();
                }
            }
        }


        public void delete_item(int id)
        {

            using (var session = Database_controller.OpenSession())
            {
                Book item;

                using (var transaction = session.BeginTransaction())
                {
                    item = (Book)session.CreateCriteria(typeof(Book))
                      .List<Book>().Where(b => b.id == id).ToList().First();
                    session.Delete(item);
                    transaction.Commit();
                }


            }
        }

        public void update_item(Book item)
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

        public string[] get_header_names(int value)
        {

            string[] names = new string[10];
            if (value == 0)
            {
                names[0] = "Id";
                names[1] = "Nazwa książki";
                names[2] = "Autorzy";
                names[3] = "Data wypożyczenia";
                names[4] = "Data oddania";
                names[5] = "Opis";
                names[6] = "Ocena";
                names[7] = "Kategoria";
                names[8] = "Wydawca";
                names[9] = "Czy była czytana";
            }
            else if (value == 1)
            {
                names[0] = "Id";
                names[1] = "Book name";
                names[2] = "Authors";
                names[3] = "Date borrowed";
                names[4] = "Date returned";
                names[5] = "Opis";
                names[6] = "Ocena";
                names[7] = "Kategoria";
                names[8] = "Wydawca";
                names[9] = "Czy była czytana";

            }
            else
            {
                names[0] = "Id";
                names[1] = "Nazwa książki";
                names[2] = "Autorzy";
                names[3] = "Data wypożyczenia";
                names[4] = "Data oddania";
                names[5] = "Opis";
                names[6] = "Ocena";
                names[7] = "Kategoria";
                names[8] = "Wydawca";
                names[9] = "Czy była czytana";

            }
            return names;
        }

        public int get_id_column_number()
        {
            return 0;
        }

        public List<Book> get_items()
        {
            using (var session = Database_controller.OpenSession())
            {


                using (session.BeginTransaction())
                {
                    return (List<Book>)session.CreateCriteria(typeof(Book))
                      .List<Book>();
                }
            }

        }


    }
}
