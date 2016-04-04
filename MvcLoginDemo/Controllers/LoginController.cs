using MvcLoginDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLoginDemo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            string username = Request["username"];
            string password = Request["password"];
            string logoutButton = Request["logoutButton"];
            if (username != null)
            {
                // försök att logga in
                List<UserModel> defaultUsers = UserModel.DefaultUsers();
                foreach(UserModel u in defaultUsers)
                {
                    if (username == u.Name)
                    {
                        if (password == u.Password)
                        {
                            Session["LoginStatus"] = true;
                            Session["username"] = username;
                        }
                        break;
                    }
                }
                /*bool validUsername = username == defaultUsers.Name;
                bool validPassword = Request["password"] == defaultUsers.Password;
                Session["LoginStatus"] = validPassword && validUsername;*/
                
                //Om inloggning lyckas: Redirect till säkra sidan
               // if (validUsername && validPassword)
               //     return Redirect("/Secure/Index");
            }
            else if (logoutButton != null)
            {
                // logga ut
                Session["LoginStatus"] = false;
                Session["username"] = null;
            }
            else
            {
                // business as usual
            }
            return View();
        }

    }
}