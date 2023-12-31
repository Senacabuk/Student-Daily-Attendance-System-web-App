﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projev2.Data
{
    public class projev2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public projev2Context() : base("name=projev2Context")
        {
            Database.SetInitializer<projev2Context>(new DropCreateDatabaseAlways<projev2Context>());
        }

        public System.Data.Entity.DbSet<projev2.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<projev2.Models.Course> Courses { get; set; }
        public System.Data.Entity.DbSet<projev2.Models.Ogrenci> Ogrencis { get; set; }
        public System.Data.Entity.DbSet<projev2.Models.Yoklama> Yoklamas { get; set; }

        public System.Data.Entity.DbSet<projev2.Models.Attendence> Attendences { get; set; }
        public System.Data.Entity.DbSet<projev2.Models.login> Users
        {
            get; set;
        }
    }
}
