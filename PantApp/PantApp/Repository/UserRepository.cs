using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PantApp.Models;

namespace PantApp.Repository
{
    public static class UserRepository
    {
        public static List<UserModel> Users { get; }

        static UserRepository()
        {
            Users = new List<UserModel>();
        }

    }
}