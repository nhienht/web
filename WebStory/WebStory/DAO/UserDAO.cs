using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Services.Description;
using System.Windows;

namespace WebStory.DAO
{
    public class UserDAO
    {
        private SqlConnection conn { get; set; }
        public UserDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }
        public int CreateUser(string tenNguoiDung, string email, string password, DateTime ngaysinh, int gioitinh)
        {
            conn.Open();
            int result = 0;
            using (conn)
            {
                try
                {
                    string insertData = "insert into nguoidung(tenNguoiDung, email, password ,ngaysinh, gioitinh)" +
                                         "values (@tenNguoiDung,@email,@password,@ngaysinh,@gioitinh)";
                    SqlCommand command = new SqlCommand(insertData, conn);


                    command.Parameters.AddWithValue("@tenNguoiDung", tenNguoiDung);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                    command.Parameters.AddWithValue("@gioitinh", gioitinh);
                    
                  
                    result = command.ExecuteNonQuery();
                    conn.Close();
                    if (result < 0)
                    {
                        return -1;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to database due to" + ex.ToString());
                    MessageBox.Show("Failed to insert data due to" + ex.ToString());
                }

            }
            return result;
        }
    }
}