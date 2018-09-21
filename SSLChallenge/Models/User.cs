using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSLChallenge.Models
{
    public class User
    {
        public string userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
    }
}