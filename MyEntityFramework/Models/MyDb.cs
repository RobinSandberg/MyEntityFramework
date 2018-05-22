using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyEntityFramework.Models
{
    public class MyDb : DbContext
    {   
        public MyDb() : base("ConnectionFirst")
        {

        }

        DbSet<Student> Students { get; set; }

        DbSet<Teacher> Teachers { get; set; }

        DbSet<Course> Courses { get; set; }

        DbSet<Assigment> Assigments { get; set; }

    }
}