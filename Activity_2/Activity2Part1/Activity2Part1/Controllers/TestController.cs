using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> userList = new List<UserModel>();
            UserModel user1 = new UserModel("Nick", "Nicholas@email.com", "123-456-7890");
            UserModel user2 = new UserModel("Ashley", "Ashley@email.com", "123-456-7890");
            UserModel user3 = new UserModel("Zane", "Zane@email.com", "123-456-7890");

            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);

            return View("Test", userList);
            // return View(new UserModel());
        }
    }
}