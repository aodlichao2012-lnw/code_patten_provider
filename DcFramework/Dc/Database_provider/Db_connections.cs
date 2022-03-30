
using MongoDB.Bson;
using MongoDB.Driver;
using MySql.Data.MySqlClient;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace datacenter
{
    public class Db_connections
    {
        object aaa;
        private Db_connections()
        {

        }
        private static Db_connections db_Connections = null;

        public static Db_connections instance
        {
            get
            {
                if (db_Connections == null)
                {
                    db_Connections = new Db_connections();
                    return db_Connections;
                }
                return db_Connections;
            }
        }
        public void ManageDatabaseSQLServerCommand(string cmd, ref object models, string Connectionsstring = "")
        {
            try
            {
                DataTable dt = new DataTable();
                using (var connecttion = new SqlConnection(Connectionsstring))
                {
                    connecttion.Open();
                    SqlDataAdapter sqlData = new SqlDataAdapter(cmd, connecttion);
                    sqlData.Fill(dt);
                    models = dt;
                    connecttion.Close();
                }
            }
            catch (Exception ex)
            {
                models = Error_providers.Instances.CustomsExceptions(ex);
            }

        }
        public void ManageDatabasePostgreServerCommand(string cmd, ref object models, string Connectionsstring = "")
        {
            try
            {
                DataTable dt = new DataTable();
                using (var connecttion = new NpgsqlConnection(Connectionsstring))
                {
                    connecttion.Open();
                    NpgsqlCommand sqlData = new NpgsqlCommand(cmd, connecttion);
                    sqlData.ExecuteNonQuery();
                    models = sqlData.ExecuteScalar();
                    connecttion.Close();
                }
            }
            catch (Exception ex)
            {
                models = Error_providers.Instances.CustomsExceptions(ex);
            }

        }
        public void ManageDatabaseOracleServerCommand(string cmd, ref object models, string Connectionsstring = "")
        {
            try
            {
                DataTable dt = new DataTable();
                using (var connecttion = new OracleConnection(Connectionsstring))
                {
                    connecttion.Open();
                    OracleCommand sqlData = new OracleCommand(cmd, connecttion);
                    sqlData.ExecuteNonQuery();
                    models = sqlData.ExecuteScalar();
                    connecttion.Close();
                }
            }
            catch (Exception ex)
            {
                models = Error_providers.Instances.CustomsExceptions(ex);
            }

        }  
        
        public void ManageDatabaseMysqlServerCommand(string cmd, ref object models, string Connectionsstring = "")
        {
            try
            {
                DataTable dt = new DataTable();
                using (var connecttion = new MySqlConnection(Connectionsstring))
                {
                    connecttion.Open();
                    MySqlCommand sqlData = new MySqlCommand(cmd, connecttion);
                    sqlData.ExecuteNonQuery();
                    models = sqlData.ExecuteScalar();
                    connecttion.Close();
                }
            }
            catch (Exception ex)
            {
                models = Error_providers.Instances.CustomsExceptions(ex);
            }

        }
        public  void ManageDatabaseMongoDbServerCommand(BsonDocument cmd, string collectionname , ref object models, string Connectionsstring = "", string databasename = "")
        {
            try
            {
                var command = cmd;
                var cilent = new MongoClient(Connectionsstring);
                var db = cilent.GetDatabase(databasename);
                var collections =  db.GetCollection<object>(collectionname);
                models = collections.Find(command).ToList();


            }
            catch (Exception ex)
            {
                models = Error_providers.Instances.CustomsExceptions(ex);
            }

        }

        public void testMongo()
        {
            var cs = new BsonDocument("Name" , new BsonDocument("", 300));
            Db_connections.instance.ManageDatabaseMongoDbServerCommand(cs,"suparat",ref aaa , "", "");
        }


    }
}
