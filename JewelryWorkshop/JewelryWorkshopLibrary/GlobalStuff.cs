using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryWorkshopLibrary.Models;

namespace JewelryWorkshopLibrary
{
    public static class GlobalStuff
    {
        public static SqlConnector Connector { get; private set; } = new SqlConnector();

        public static string GetConnectionString(string connectionStringName)
        {
            return ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }
    }
}
