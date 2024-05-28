using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginPage.Controllers
{
    public class LoginPageController:Controller
    {
        LoginPageDbContext ldb = new LoginPageDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LoginModel l)
        {
            LoginPageDbContext ldb = new LoginPageDbContext();
            foreach(var i in ldb.credentials)
            {
                if(l.UserName == i.UserName){
                    if(l.Password == i.Password){
                        return Content("<h2>Login successfull</h2>","text/html");
                    }
                }
            }
            return Content("<h2>Incorrect Username or Password</h2>","text/html");
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult AddUser(LoginModel l)
        {

            Console.WriteLine(l.UserName);
            ldb.Add(l);
            ldb.SaveChanges();
            return Content("<h2>Registration Successfull</h2>","text/html");
        }

    }
}