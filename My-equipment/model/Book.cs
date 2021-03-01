using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.model
{
    public class Book : Generic_entity
    {
        public virtual int id { get; set; }
        public virtual IList<Author> authors { get; set; }
        public virtual string book_name { get; set; }
        public virtual DateTime date_borrowed { get; set; }
        public virtual DateTime date_returned { get; set; }
        public virtual Genre genre { get; set; }

        public virtual Publisher publisher { get; set; }

        public virtual float rating { get; set; }

        public virtual string description { get; set; }

        public virtual bool has_been_readed { get; set; }

        public Book()
        {

        }

        public Book(Book book)
        {
            this.authors = book.authors;
            this.book_name = book.book_name;
            this.date_borrowed = book.date_borrowed;
            this.date_returned = book.date_returned;
            this.description = book.description;
            this.genre = book.genre;
            this.has_been_readed = book.has_been_readed;
            this.id = book.id;
            this.publisher = book.publisher;
            this.rating = book.rating;

        }
        public Book(int id, List<Author> authors, string book_name, DateTime date_borrowed, DateTime date_return, Genre genre, Publisher publisher, float rating, string description, bool has_been_readed)
        {
            this.id = id;
            this.authors = authors;
            this.book_name = book_name;
            this.date_borrowed = date_borrowed;
            this.date_returned = date_returned;
            this.genre = genre;
            this.publisher = publisher;
            this.rating = rating;
            this.description = description;
            this.has_been_readed = has_been_readed;
        }

        public Book(string value)
        {
            string[] values = value.Split(';');
            this.id = int.Parse(values[0]);
            this.book_name = values[1];
            this.date_borrowed = Convert.ToDateTime(values[2]);
            this.date_returned = Convert.ToDateTime(values[3]);
            this.genre = new Genre(values[4]);
            this.publisher = new Publisher(values[5]);

            this.rating = float.Parse(values[6]);
            this.description = values[7];
            this.has_been_readed = Convert.ToBoolean(values[8]);
        }

        public override bool Equals(object obj)
        {
            Book book = (Book)obj;
            if (
                (NHibernateUtil.IsInitialized(book.authors) && this.authors.SequenceEqual(book.authors)) || !NHibernateUtil.IsInitialized(book.authors) &&
                this.book_name.Equals(book.book_name) &&
                this.date_borrowed.Equals(book.date_borrowed) &&
                this.date_returned.Equals(book.date_returned) &&
                this.description.Equals(book.description) &&
                (NHibernateUtil.IsInitialized(book.genre) && this.genre.Equals(book.genre)) || !NHibernateUtil.IsInitialized(book.genre) &&
                this.has_been_readed == book.has_been_readed &&
                this.id == book.id &&
                (NHibernateUtil.IsInitialized(book.publisher) && this.publisher.Equals(book.publisher)) || !NHibernateUtil.IsInitialized(book.publisher) &&
                this.rating == book.rating
                )
            {

                return true;


            }
            else
            {
                return false;
            }
        }

        public override string to_csv()
        {
            return this.id + ";" + this.book_name + ";" + this.date_borrowed.ToString() + ";" + this.date_returned.ToString() + ";" + this.genre.name + ";" + this.publisher.name + ";" + this.rating + ";" + this.description + ";" + this.has_been_readed.ToString();
        }


    }
}
