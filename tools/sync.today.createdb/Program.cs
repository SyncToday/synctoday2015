using Oak;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDB
{
    class Program
    {
        public static void PurgeDb(Seed seed)
        {
            ConnectionProfile cp = new ConnectionProfile();
            SqlConnectionStringBuilder conn_orig = new SqlConnectionStringBuilder(cp.ConnectionString);
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder(cp.ConnectionString) { ConnectTimeout = 5, InitialCatalog = "master" }; // you can add other parameters.
            using (SqlConnection cnn = new SqlConnection(conn.ConnectionString))
            {
                cnn.Open();

                using (SqlCommand dbCreate = new SqlCommand())
                {
                    dbCreate.CommandText = string.Format(@"IF db_id('{0}') IS NULL CREATE DATABASE [{0}]", conn_orig.InitialCatalog);
                    dbCreate.Connection = cnn;
                    try
                    {
                        dbCreate.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(string.Format("create database [{0}] FAILED with {1}", conn_orig.InitialCatalog, ex.Message ));
                    }
                }
            }

            seed.PurgeDb();
        }


        static void Main(string[] args)
        {
            ConnectionProfile.connectionString = @"Server=(localdb)\ProjectsV12; Database=SyncToday2015.new; Trusted_Connection=True;";
            if (args.Length >0) ConnectionProfile.connectionString = args[0];
            var seed = new Seed();
            PurgeDb(seed);
            var schema = new Schema(seed);
            schema.Scripts().ForEach<dynamic>(s => seed.ExecuteNonQuery(s()));
        }
    }
}
