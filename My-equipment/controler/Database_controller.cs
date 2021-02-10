﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.controler
{
    class Database_controller
    {
        SqlConnection sqlConnection;

        public void createDatabase()
        {

            insert_create_delete("CREATE TABLE items(ID int IDENTITY(1,1) PRIMARY KEY," +
                "item_name varchar(255) NOT NULL," +
                "item_bought DATE," +
                "item_retired DATE," +
                "price float," +
                "description varchar(255)," +
                "company_name varchar(255)," +
                "rating float," +
                "); ");

            insert_create_delete("CREATE TABLE Headphones(ID int FOREIGN KEY REFERENCES items(id) ON DELETE CASCADE," +
                "cable_lenght float," +
                "microphone bit," +
                "volume_setter bit," +
                "mute_button bit," +
                "); ");


        }
        public void connect()
        {
            sqlConnection.Open();
        }

        public int insert_create_delete_return_id(string querry)
        {
            SqlCommand cmd = new SqlCommand(querry, sqlConnection);
            connect();
            //cmd.ExecuteNonQuery();

            Int32 newId = (Int32)cmd.ExecuteScalar();
            disconnect();
            return newId;
        }
        public void insert_create_delete(string querry)
        {
            SqlCommand cmd = new SqlCommand(querry, sqlConnection);
            connect();
            cmd.ExecuteNonQuery();
            disconnect();
        }
        public void disconnect()
        {
            sqlConnection.Close();
        }

        public Database_controller()
        {
            string connetionString;
            connetionString = @"Server=(localdb)\MSSQLLocalDB;Database=my_equipment;Integrated Security=true;";
            sqlConnection = new SqlConnection(connetionString);
        }

        public SqlDataReader select(string querry)
        {

            SqlCommand cmd;
            connect();
            cmd = new SqlCommand(querry, sqlConnection);
            SqlDataReader dreader = cmd.ExecuteReader();
            return dreader;
        }

    }
}
