using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

namespace SSLChallenge.Models
{
    public class Module
    {
        [Key]
        public string macAddressID { get; set; }
        public DateTime issuedDate { get; set; }
        public string studentResponsible { get; set; }
    }
}