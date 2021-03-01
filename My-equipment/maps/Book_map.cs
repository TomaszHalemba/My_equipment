using FluentNHibernate.Mapping;
using My_equipment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.maps
{
    class Book_map : ClassMap<Book>
    {
        public Book_map()
        {
            Id(x => x.id, "Book_id");
            Map(x => x.book_name);
            Map(x => x.date_borrowed);
            Map(x => x.date_returned);
            Map(x => x.description);
            Map(x => x.rating);
            Map(x => x.has_been_readed);
            References(x => x.genre).Cascade.SaveUpdate() //#3
            .Column("genre");//.Not.LazyLoad();
            References(x => x.publisher).Cascade.SaveUpdate() //#3
            .Column("publisher");//.Not.LazyLoad();


            HasManyToMany(x => x.authors).Table("Book_Author").Cascade.All()//.Not.LazyLoad()
                    .ParentKeyColumn("Book_id")
                    .ChildKeyColumn("Author_id");

        }
    }
}


