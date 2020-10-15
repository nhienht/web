using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
namespace WebStory.DBConnection
{
    public class DBConnection
    {
        public SqlConnection conn { get; set; }

        public DBConnection()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["PRN"].ConnectionString;

            this.conn = new SqlConnection(mainconn);
        }
    }
}