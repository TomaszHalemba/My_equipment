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
        class join_table
        {
            public int x;
            public int y;
            public join_table() { }
            public join_table(string text)
            {
                string[] tmp = text.Split(';');
                this.x = int.Parse(tmp[0]);
                this.y = int.Parse(tmp[1]);
            }
            public join_table(int x, int y)
            {
                this.x = x;
                this.y = x;
            }
        }

        Item_dao item_Dao = new Item_dao();
        Headphohe_dao headphohe_Dao = new Headphohe_dao();
        Book_dao book_Dao = new Book_dao();
        Author_dao author_Dao = new Author_dao();
        Genre_dao genre_Dao = new Genre_dao();
        Publisher_dao publisher_Dao = new Publisher_dao();


        private void save_list_to_csv<class_type>(string filename, List<class_type> list) where class_type : Generic_entity
        {

            using (StreamWriter sw = File.CreateText(filename))
            {
                foreach (class_type item in list)
                {
                    sw.WriteLine(item.to_csv());
                }
            }

        }

        private void save_list_to_csv(string filename, List<Author> list)
        {
            using (StreamWriter authors_book = File.CreateText("authors_book.csv"))
            {
                using (StreamWriter sw = File.CreateText(filename))
                {
                    foreach (Author author in list)
                    {
                        sw.WriteLine(author.to_csv());

                        foreach (Book book in author.books)
                        {
                            authors_book.WriteLine(author.id + ";" + book.id);
                        }
                    }
                }
            }

        }


        private void add_all<class_type, class_dao>(List<class_type> list, class_dao dao)
            where class_type : Generic_entity
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
            save_list_to_csv("publishers.csv", publisher_Dao.get_items());
            save_list_to_csv("genre.csv", genre_Dao.get_items());

            save_list_to_csv("books.csv", book_Dao.get_items());
            save_list_to_csv("Authors.csv", author_Dao.get_items());
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

            List<Book> books = File.ReadAllLines("books.csv")
                  .Select(v => new Book(v))
                  .ToList();

            List<Genre> genres = File.ReadAllLines("genre.csv")
          .Select(v => new Genre(int.Parse(v.Split(';')[0]), v.Split(';')[1]))
          .ToList();

            add_all(genres, genre_Dao);



            List<Publisher> publishers = File.ReadAllLines("publishers.csv")
          .Select(v => new Publisher(int.Parse(v.Split(';')[0]), v.Split(';')[1]))
          .ToList();

            add_all(publishers, publisher_Dao);

            List<Author> authors = File.ReadAllLines("authors.csv")
                  .Select(v => new Author(v))
                  .ToList();


            List<int> old_author_ids = authors.Select(a => a.id).ToList();

            add_all(authors, author_Dao);

            List<join_table> book_author = File.ReadAllLines("authors_book.csv")
                  .Select(v => new join_table(v))
                  .ToList();


            Dictionary<int, int> author_id_dict = new Dictionary<int, int>();

            for (int a = 0; a < authors.Count; a++)
            {
                author_id_dict.Add(old_author_ids[a], authors[a].id);
            }

            book_author.ForEach(ba => ba.x = author_id_dict[ba.x]);


            books.ForEach(b =>
            {
                b.authors = (from auth in authors
                             where (
                                   from c in book_author
                                   where c.y == b.id
                                   select c.x).ToList()
                             .Contains(auth.id)
                             select auth).ToList();

                b.genre = (from genre in genres
                           where genre.name.Equals(b.genre.name)
                           select genre).FirstOrDefault();

                b.publisher = (from publisher in publishers
                               where publisher.name == b.publisher.name
                               select publisher).FirstOrDefault();
            });





            add_all(books, book_Dao);

        }


    }
}
