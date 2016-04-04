using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLoginDemo.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public static List<UserModel> DefaultUsers()
        {
            return new List<UserModel>()
            {
                new UserModel()
                {
                    Name = "david",
                    Password = "12345678"
                },
                new UserModel()
                {
                    Name="tomten",
                    Password="godjul"
                }
            };
        }
    }
}