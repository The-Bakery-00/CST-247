using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UserService
{
    [DataContract]
    public class UserDTO
    {

        [DataMember]
        public List<Users> userList { get; set; }
        [DataMember]
        public int ErrorCode { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }

    }
}