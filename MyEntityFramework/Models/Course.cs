using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEntityFramework.Models
{
    public class Course
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }

        public List<Assigment> Assigments { get; set; }
    }
}