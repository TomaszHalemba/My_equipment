using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Data.SqlClient;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_equipment.model;
using NHibernate.Tool.hbm2ddl;

namespace My_equipment.controler
{
    public class Database_controller
    {
        SqlConnection sqlConnection;


        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static void set_session_factory(ISessionFactory sessionFactory)
        {

            _sessionFactory = sessionFactory;
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = (ISessionFactory)Fluently.Configure()
        .Database(
               MsSqlConfiguration.MsSql2012.ConnectionString(@"Server=(localdb)\MSSQLLocalDB;Database=my_equipment;Integrated Security=true;")
              )
              .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<Item>()
                ).ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
              .BuildSessionFactory();

        }


        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {

            return Fluently.Configure()
           .Database(
               MsSqlConfiguration.MsSql2012.ConnectionString(@"Server=(localdb)\MSSQLLocalDB;Database=my_equipment;Integrated Security=true;")
              )
              .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<Item>()
                )
              .BuildSessionFactory();
        }


    }
}
