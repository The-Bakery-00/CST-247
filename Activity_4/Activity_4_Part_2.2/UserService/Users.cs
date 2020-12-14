using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UserService
{
    [DataContract]
    public class Users
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool PreferredCustomer { get; set; }
        [DataMember]
        public float Income { get; set; }
        [DataMember]
        public List<int> Highscores { get; set; }

        public Users(int id, string name, bool preferredCustomer, float income, List<int> highscores)
        {
            Id = id;
            Name = name;
            PreferredCustomer = preferredCustomer;
            Income = income;
            Highscores = highscores;
        }
    }
}