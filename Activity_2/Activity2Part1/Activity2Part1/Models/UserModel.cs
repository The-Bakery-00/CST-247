using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity2Part1.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }


        public UserModel()
        {
            // Do Nothing
        }


        public UserModel(string name, string email, string phone)
        {
            this.Name = name;
            this.EmailAddress = email;
            this.PhoneNumber = phone;
        }

    }
}
    