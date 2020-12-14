using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        Random random = new Random();
        List<Users> userList = new List<Users>();

        public Service1()
        {

            Users u1 = new Users(1, "Nick", true, 9000, GetSomeRandomScores(random));
            Users u2 = new Users(2, "Ashley", false, 25000, GetSomeRandomScores(random));
            Users u3 = new Users(3, "Zane", false, 82000, GetSomeRandomScores(random));
            Users u4 = new Users(4, "Devyn", true, 103000, GetSomeRandomScores(random));
            Users u5 = new Users(5, "Kenze", true, 33000, GetSomeRandomScores(random));

            userList.Add(u1);
            userList.Add(u2);
            userList.Add(u3);
            userList.Add(u4);
            userList.Add(u5);

        }

        private static List<int> GetSomeRandomScores(Random r)
        {
            List<int> listOfScores = new List<int>();
            for (int i = 0; i < r.Next(10); i++)
            {
                listOfScores.Add(r.Next(100));
            }
            return listOfScores;
        }

        public UserDTO GetAllUsers()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.ErrorCode = 1;
            userDTO.ErrorMsg = "Everybody is here";
            userDTO.userList = userList;
            return userDTO;
        }

        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public UserDTO GetUser(string id)
        {
            UserDTO userDTO = new UserDTO();

            List<Users> returnUsers = userList.Where(x => x.Id == Int32.Parse(id)).ToList();

            userDTO.userList = returnUsers;
            userDTO.ErrorCode = returnUsers.Count;
            userDTO.ErrorMsg = "The people who have a '" + id + "' as their ID number.";
            return userDTO;
        }

        public UserDTO GetUsersByName(string name)
        {
            UserDTO userDTO = new UserDTO();

            List<Users> returnUsers = userList.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();

            userDTO.userList = returnUsers;
            userDTO.ErrorCode = returnUsers.Count;
            userDTO.ErrorMsg = "The people who have a '" + name + "' in their name.";
            return userDTO;
        }
    }
}
