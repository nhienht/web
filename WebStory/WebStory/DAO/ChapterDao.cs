using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStory.Models;

namespace WebStory.DAO
{

    public class ChapterDao
    {
        private MySqlConnection conn { get; set; }
        public ChapterDao()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }
        public int insertChapter(Chapter c)
        {
            if(c.getIdTruyen() <= 1)
            {
                
            }

            return -1;
        }
    }
}