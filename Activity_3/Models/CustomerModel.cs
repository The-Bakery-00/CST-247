﻿namespace Activity_3.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public CustomerModel(int iD, string name, int age)
        {
            ID = iD;
            Name = name;
            Age = age;
        }
    }
}