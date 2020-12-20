using Activit5.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activit5.Controllers
{
    public class TestLoggingService2Controller : Controller
    {

        public ILogger logger { get; set; }


        // GET: TestLoggingService2
        [Attributes]
        public string Index()
        {
            logger.Info("test string");
            return "returning a string";
        }
    }
}