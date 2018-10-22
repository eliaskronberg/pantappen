using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PantApp.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int Balance { get; set; }
        public int RecycledCans { get; set; }

    }
}