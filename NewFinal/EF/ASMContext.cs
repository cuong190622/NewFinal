
using Microsoft.AspNet.Identity.EntityFramework;
using NewFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewFinal.EF
{
    public class ASMContext : DbContext
    {
        public ASMContext() : base("ASMConnection")
        {
      
        }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<CourseCategoryEntity> courseCategories { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEntity>().ToTable("Course");
            modelBuilder.Entity<CourseCategoryEntity>().ToTable("CourseCategory");
            modelBuilder.Entity<UserEntity>().ToTable("Users");
        }

        }

}
