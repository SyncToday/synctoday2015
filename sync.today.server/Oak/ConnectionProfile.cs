using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Oak
{
    public class ConnectionProfile
    {
        private string connectionString;
        public string ConnectionString
        {
            get
            {
                //feel free to change this and just return your connection string
                if (!string.IsNullOrEmpty(connectionString)) return connectionString;
                    
                //get the first connection string that is defined in project's configuration file (excludes machine.config and company)
                foreach (ConnectionStringSettings config in ConfigurationManager.ConnectionStrings)
                {
                    if (DefinedInProjectConfigFile(config)) return config.ConnectionString;
                }

                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }

        bool DefinedInProjectConfigFile(ConnectionStringSettings config)
        {
            return config.ElementInformation.Source != null;
        }
    }
}