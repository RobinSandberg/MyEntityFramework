﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEntityFramework.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Course> Courses { get; set; }

        public List<Assigment> Assigments { get; set; }



    }
}