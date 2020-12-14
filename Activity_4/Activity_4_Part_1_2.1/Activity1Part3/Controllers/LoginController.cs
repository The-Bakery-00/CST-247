using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using System;
using NLog;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using LogManager = NLog.LogManager;
using Activity1Part3.Services.Utilities;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        //private static Logger logger = LogManager.GetLogger("myAppLoggerRules");

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(UserModel model) 
        {

            // put an item in the log
            // logger.Info("Entering the login controller. Login Method");
            MyLogger.GetInstance().Info("Entering the login controller. Login Method");

            try
            {

                if (!ModelState.IsValid)
                    return View("Login");

                SecurityService authService = new SecurityService();

                bool authorized = authService.Authenticate(model);

                if (authorized)
                {
                    // logger.Info("Exit login controller. Login success!!");
                    MyLogger.GetInstance().Info("Exit login controller. Login success!!");
                    return View("LoginPassed", model);
                }
                else
                {
                    // logger.Info("Exit login controller. Login failed!!");
                    MyLogger.GetInstance().Info("Exit login controller. Login failed!!");
                    return View("LoginFailed");
                }
     
            }
            catch (Exception e)
            {
                // logger.Error("Exception! " + e.Message);
                MyLogger.GetInstance().Error("Exception! " + e.Message);
                return Content("Exception in login" + e.Message);
            }
        }
    }
}