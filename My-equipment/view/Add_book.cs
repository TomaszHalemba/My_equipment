using My_equipment.dao;
using System;
using My_equipment.model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_equipment.builders;
using My_equipment.controler;

namespace My_equipment.view
{
    public partial class Add_book : Form
    {
        int mode = 0;//0-add 1-modify
        Book_dao item_Dao = new Book_dao();
        int item_id = 0;
        private Book book_context;
        public Add_book()
        {
            InitializeComponent();
            add_item_button.Visible = true;
            modify_button.Visible = false;


        }
        public Add_book(int mode)
        {
            InitializeComponent();
            this.mode = mode;
            add_item_button.Visible = false;
            modify_button.Visible = false;

            if (mode == 0)
            {
                add_item_button.Visible = true;
            }
            else
            if (mode == 1)
            {
                modify_button.Visible = true;
            }
        }
        public Add_book(int mode, Book item)
        {
            InitializeComponent();
            add_item_button.Visible = false;
            modify_button.Visible = false;
            book_context = item;

            if (mode == 0)
            {
                add_item_button.Visible = true;
            }
            else
            if (mode == 1)
            {
                modify_button.Visible = true;
                set_values(item);
            }
        }

        private void set_values(Book item)
        {
            item_id = item.id;
            book_name_textbox.Text = item.book_name;
            authors_textbox.Text = get_string_from_authors(item.authors);
            if (item.date_borrowed == DateTime.MinValue)
            {
                borrow_date_checkbox.Checked = true;
            }
            else
            {
                borrow_date_picker.Value = item.date_borrowed;
                borrow_date_checkbox.Checked = false;
            }

            if (item.date_returned == DateTime.MinValue)
            {
                return_date_checkbox.Checked = true;
            }
            else
            {
                returned_date_picker.Value = item.date_returned;
                return_date_checkbox.Checked = false;
            }


            genre_textbox.Text = item.genre.name;
            description_textbox.Text = item.description;
            publisher_textbox.Text = item.publisher.name;
            rating_textbox.Text = item.rating.ToString();
        }

        private string get_string_from_authors(IList<Author> authors)
        {
            return String.Join(";", authors.Select(m => m.first_name + "," + m.last_name + ", " + m.birth_date.ToString()).ToArray());
        }
        private IEnumerable<Author> get_authors_from_string(string text)
        {
            if (!text.Equals(""))
            {
                foreach (string author in text.Split(';'))
                {
                    string[] names = author.Split(',');
                    yield return new Author(names[0], names[1], DateTime.Parse(names[2]));
                }
            }
        }
        private Book get_item_from_form()
        {
            book_context = book_context ?? new Book();
            string book_name = book_name_textbox.Text;
            DateTime date_borrow = new DateTime();
            DateTime date_returned = new DateTime();
            List<Author> authors = get_authors_from_string(authors_textbox.Text).ToList();
            Genre genre = new Genre(genre_textbox.Text);
            string description = description_textbox.Text;
            Publisher publisher = new Publisher(publisher_textbox.Text);
            float rating = float.Parse(rating_textbox.Text);
            bool was_been_readed = is_readed_checkbox.Checked;


            if (!return_date_checkbox.Checked)
            {
                date_returned = returned_date_picker.Value;
                book_context.date_returned = date_returned;
            }
            if (!borrow_date_checkbox.Checked)
            {
                date_borrow = borrow_date_picker.Value;
                book_context.date_borrowed = date_borrow;
            }

           


            using (var session = Database_controller.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    IList<Genre> tmp = session.CreateCriteria(typeof(Genre))
                      .List<Genre>().Where(g => g.name.Equals(genre_textbox.Text)).ToList();
                    if (tmp.Count == 0)
                    {
                        book_context.genre = new Genre(genre_textbox.Text);
                    }
                    else
                    {
                        book_context.genre = new Genre(tmp.First().id,genre_textbox.Text);
                        
                    }

                }
            }


            using (var session = Database_controller.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    IList<Publisher> tmp = session.CreateCriteria(typeof(Publisher))
                      .List<Publisher>().Where(g => g.name.Equals(publisher_textbox.Text)).ToList();
                    if (tmp.Count == 0)
                    {
                        book_context.publisher = new Publisher(publisher_textbox.Text);
                    }
                    else
                    {
                        book_context.publisher = new Publisher(tmp.First().id, tmp.First().name);
                    }

                }
            }


            
             book_context.rating = rating;
            book_context.has_been_readed = was_been_readed;
            book_context.book_name = book_name;
            book_context.description = description;




            return book_context;

        }

        private void add_item_button_Click(object sender, EventArgs e)
        {
            book_context = null;
            item_Dao.add_item(get_item_from_form());
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {


            item_Dao.update_item(get_item_from_form());
        }
    }
}
