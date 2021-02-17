using My_equipment.interfaces;
using My_equipment.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_equipment.controler;

namespace My_equipment.dao
{
    class Headphohe_dao : Item_interface<Headphone>, Form_interface<Headphone>
    {


        public void add_item(Headphone item)
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

        public void delete_item(Headphone item)
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

        public void delete_item(int id)
        {

            using (var session = Database_controller.OpenSession())
            {

                using (var transaction = session.BeginTransaction())
                {
                    var queryString = string.Format("delete Item where id = :id");
                    session.CreateQuery(queryString)
                           .SetParameter("id", id)
                           .ExecuteUpdate();

                    transaction.Commit();
                }

            }
        }

        public string[] get_header_names(int value)
        {
            string[] names = new string[12];
            if (value == 0)
            {
                names[0] = "Długość kabla";
                names[1] = "Mikrofon";
                names[2] = "Sterowanie dźwiękiem";
                names[3] = "Wyłącznik mikrofonu";
                names[4] = "Id";
                names[5] = "Nazwa przedmiotu";
                names[6] = "Data zakupu";
                names[7] = "Data zepsucia";
                names[8] = "Cena";
                names[9] = "Nazwa firmy";
                names[10] = "Ocena";
                names[11] = "Opis";
            }
            else if (value == 1)
            {
                names[0] = "Id";
                names[1] = "Item name";
                names[2] = "Date bought";
                names[3] = "Date retired";
                names[4] = "Price";

                names[5] = "Company name";
                names[6] = "Rating";
                names[7] = "Description";
                names[8] = "Cable lenght";
                names[9] = "Microphone";
                names[10] = "Volume setter";
                names[11] = "Mute button";

            }
            else
            {
                names[0] = "Długość kabla";
                names[1] = "Mikrofon";
                names[2] = "Sterowanie dźwiękiem";
                names[3] = "Wyłącznik mikrofonu";
                names[4] = "Id";
                names[5] = "Nazwa przedmiotu";
                names[6] = "Data zakupu";
                names[7] = "Data zepsucia";
                names[8] = "Cena";
                names[9] = "Nazwa firmy";
                names[10] = "Ocena";
                names[11] = "Opis";

            }
            return names;
        }

        public List<Headphone> get_items()
        {
            List<Headphone> headphones = new List<Headphone>();


            using (var session = Database_controller.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    headphones = (List<Headphone>)session.CreateCriteria(typeof(Headphone))
                      .List<Headphone>();
                }
            }


            return headphones;
        }

        public Headphone get_item_from_row(DataGridViewRow row)
        {

            int id = (int)row.Cells[4].Value;
            float cable_lenght = (float)row.Cells[0].Value;
            bool microphone = (bool)row.Cells[1].Value;
            bool volume_setter = (bool)row.Cells[2].Value;
            bool mute_button = (bool)row.Cells[3].Value;
            string item_name = (string)row.Cells[5].Value;
            DateTime item_bought = (DateTime)row.Cells[6].Value;
            DateTime item_retired = (DateTime)row.Cells[7].Value;
            float price = (float)row.Cells[8].Value;
            string company_name = (string)row.Cells[9].Value;
            float rating = (float)row.Cells[10].Value;
            string description = (string)row.Cells[11].Value;





            return new Headphone(new model.Item(item_name, item_bought, item_retired, price, description, company_name, rating, id), cable_lenght, microphone, volume_setter, mute_button);

        }

        public void update_item(Headphone item)
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
        public int get_id_column_number()
        {
            return 4;
        }
    }
}
