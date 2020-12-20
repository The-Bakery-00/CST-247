using Activit5.Models;
using Activit5.Services.Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activit5.Services.Business {
    public class SecurityService {

        public bool Authenticate(UserModel user) {
            SecurityDAO service = new SecurityDAO();
            return service.FindByUser(user);
        }

    }
}