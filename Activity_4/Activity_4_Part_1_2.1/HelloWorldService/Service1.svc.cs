using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
  
    public class Service1 : IService1
    {
        public string GetData(string value)
        {

            return "If your voice travels " + value + " feet, then the influence of your voice will cover " + Int32.Parse(value) * Int32.Parse(value) * 3.14 + " sq feet.";
        }

        public HelloObject GetModelObject(string id)
        {
            HelloObject helloObject = new HelloObject();

            if (Int32.Parse(id) > 0)
            {
                helloObject.happyHello = true;
                helloObject.helloMessage = "Shake and bake";
            }
            else
            {
                helloObject.happyHello = false;
                helloObject.helloMessage = "Hello Mellow";
            }

            return helloObject;
        }

        public string SayHello()
        {
            return "Say Hello";
        }
    }
}
