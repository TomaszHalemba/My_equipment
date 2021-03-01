using My_equipment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.datagrid_classes
{
    public class Book_view
    {

        public int id { get; set; }
        public string book_name { get; set; }
        public string authors { get; set; }
        public DateTime date_borrowed { get; set; }
        public DateTime date_returned { get; set; }
        public string description { get; set; }
        public float rating { get; set; }
        public string genre { get; set; }
        public string publisher { get; set; }
        public bool has_been_readed { get; set; }



        public Book_view(int id, string book_name, string authors, DateTime date_borrowed, DateTime date_returned, string description, float rating, string genre, string publisher, bool has_been_readed)
        {
            this.id = id;
            this.book_name = book_name;
            this.authors = authors;
            this.date_borrowed = date_borrowed;
            this.date_returned = date_returned;
            this.description = description;
            this.rating = rating;
            this.genre = genre;
            this.publisher = publisher;
            this.has_been_readed = has_been_readed;
        }
        public Book_view(Book book)
        {
            this.id = book.id;
            this.book_name = book.book_name;
            this.authors = String.Join(";", book.authors.Select(m => m.first_name + " " + m.last_name).ToArray());
            this.date_borrowed = book.date_borrowed;
            this.date_returned = book.date_returned;
            this.description = book.description;
            this.rating = book.rating;
            this.genre = book.genre.name;
            this.publisher = book.publisher.name;
            this.has_been_readed = book.has_been_readed;
        }

        public override bool Equals(object obj)
        {
            Book_view book_View = (Book_view)obj;

            if (this.authors.Equals(book_View.authors) &&
                this.book_name.Equals(book_View.book_name) &&
                this.date_borrowed.Equals(book_View.date_borrowed) &&
                this.date_returned.Equals(book_View.date_returned) &&
                this.description.Equals(book_View.description) &&
                this.genre.Equals(book_View.genre) &&
                this.has_been_readed == book_View.has_been_readed &&
                this.id == book_View.id &&
                this.publisher.Equals(book_View.publisher) &&
                this.rating == book_View.rating
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
