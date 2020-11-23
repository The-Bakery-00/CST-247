using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttonList = new List<ButtonModel>();

        // GET: Button
        public ActionResult Index()
        {
            ButtonModel button1 = new ButtonModel(false);
            ButtonModel button2 = new ButtonModel(true);
            buttonList.Add(button1);
            buttonList.Add(button2);

            return View("Button", buttonList);
        }

        public ActionResult OnButtonClick(string mine)
        {
            if (mine == "1")
            {
                buttonList[0].State = !buttonList[0].State;
            }

            if (mine == "2")
            {
                buttonList[1].State = !buttonList[1].State;
            }
            return View("Button", buttonList);
        }
    }
}