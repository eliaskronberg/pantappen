using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PantApp.Repository;

namespace PantApp.Models
{
    public class UserModel
    {
        public UserModel(string name)
        {
            Id = UserRepository.Users.Count + 1;
            Name = name;
        }
        public int Id { get;}
        public string Name { get; }
        public int Balance { get; set; }
        public int RecycledCans { get; set; }
    }
}