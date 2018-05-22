using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEntityFramework.Models
{
    public class Assigment
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public List<Student> Students { get; set; }

        public List<Course> Courses { get; set; }
    }
}