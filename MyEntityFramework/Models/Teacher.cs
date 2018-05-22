using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEntityFramework.Models
{
    public class Teacher
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}