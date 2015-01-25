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
                    dbCreate.ExecuteNonQuery();
                }
            }

            seed.PurgeDb();
        }


        static void Main(string[] args)
        {
            var seed = new Seed();
            PurgeDb(seed);
            var schema = new Schema(seed);
            schema.Scripts().ForEach<dynamic>(s => seed.ExecuteNonQuery(s()));
        }
    }
}
