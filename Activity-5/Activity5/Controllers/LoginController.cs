using Activit5.Models;
using Activit5.Services.Business;
using Activit5.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activit5.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger logger;


        public LoginController(ILogger logger) {
            this.logger = logger;
        }
        
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            logger.Info("Reached LoginController::Index()");
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(UserModel model) {
            logger.Info("Reached LoginController::Login() method");
            if (!ModelState.IsValid) {
                logger.Info("Login was invalid with the follow credentials: " + model.Username + " " + model.Password);
                return View("Login");
            }

            SecurityService authService = new SecurityService();

            bool authorized = authService.Authenticate(model);

            if (authorized) {
                Session["user"] = model.Username;
                Session.Timeout = 20;
                return View("LoginPassed", model);
            } else {
                return View("LoginFailed");
            }
        }
    }
}