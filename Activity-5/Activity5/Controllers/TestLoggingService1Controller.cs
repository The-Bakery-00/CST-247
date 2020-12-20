using Activit5.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activit5.Controllers
{
    public class TestLoggingService1Controller : Controller
    {
        private ILogger logger;

        public TestLoggingService1Controller(ILogger log) {
            this.logger = log;
        }

        // GET: TestLoggingService1
        [Attributes]
        public string Index()
        {
            logger.Info("testing logger 1");
            return "tested logger 1";
        }
    }
}