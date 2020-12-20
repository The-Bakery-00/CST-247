using Activit5.Services.Business;
using Activit5.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activit5.Controllers
{
    public class TestLoggingService3Controller : Controller
    {
        private ILogger logger;
        private ITestService service;

        public TestLoggingService3Controller(ILogger log, ITestService svc) {
            this.logger = log;
            this.service = svc;
        }

        // GET: TestLoggingService3
        [Attributes]
        public string Index()
        {
            logger.Info("String 3 log");
        
            return "String 3 test";
        }
    }
}