using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStory.DAO;
using WebStory.Models;

namespace WebStory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register(FormCollection formCollection)
        {
            UserDAO u = new UserDAO();
            string tenNguoiDung = formCollection["tenNguoiDung"];
            string email = formCollection["email"];
            string password = formCollection["password"];
          
            DateTime ngaysinh = Convert.ToDateTime(formCollection["ngaysinh"]);
            int gioitinh = Convert.ToInt32(formCollection["gioitinh"]);
            
       

            u.CreateUser(tenNguoiDung, email, password, ngaysinh, gioitinh);
            


            return View();
        }

        
    }
}