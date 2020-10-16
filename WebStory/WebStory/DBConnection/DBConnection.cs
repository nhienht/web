using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WebStory.DBConnection
{
    public class DBConnection
    {
        public MySqlConnection conn { get; set; }

        public DBConnection()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["PRN"].ConnectionString;

            this.conn = new MySqlConnection(mainconn);
        }
    }
}