using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentSampleAPI.Student.DataAcces
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
           : base(options)
        {
        }

        //DbSets that connects to the database
        public DbSet<Student> Students { get; set; }
        public DbSet<Assignment> Assignments { get; set; }


        //Uncomment the line below to Seed Db on Adding Migration
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(

                //Type of customers within the store 
                new Student()
                {
                    Id = 1,
                    Name = "Mark Almson",
                    DateOfBirth = new DateTime(1996, 05, 11),
                    Age = 24,
                    Created_at = DateTime.Now
                },
                new Student()
                {
                    Id = 2,
                    Name = "John Rice",
                    DateOfBirth = new DateTime(1995, 05, 11),
                    Age = 25,
                    Created_at = DateTime.Now
                },
                 new Student()
                 {
                     Id = 3,
                     Name = "Olakunmi Sodiq",
                     DateOfBirth = new DateTime(1996, 05, 11),
                     Age = 24,
                     Created_at = DateTime.Now

                 },
                 new Student()
                 {
                     Id = 4,
                     Name = "Foluke Balagon",
                     DateOfBirth = new DateTime(1996, 05, 11),
                     Age = 24,
                     Created_at = DateTime.Now
                 }
            );

            modelBuilder.Entity<Assignment>().HasData(

                //Assignements  
                new Assignment()
                {
                    Id = 1,
                    Name = " Algorithim Sample",
                    Description = "This assignemnt contains some algorithim samplee",
                    StudentId = 1,
                    DateOfSubmission = new DateTime(2021, 02, 28) // Assume correct deadline is 28th
                },
                new Assignment()
                {
                    Id = 2,
                    Name = " Algorithim Sample",
                    Description = "This assignemnt contains some algorithim samplee",
                    StudentId = 2,
                    DateOfSubmission = new DateTime(2021, 03, 19) // Assume correct deadline is 28th
                },
                 new Assignment()
                 {
                     Id = 3,
                     Name = " Algorithim Sample",
                     Description = "This assignemnt contains some algorithim samplee",
                     StudentId = 3,
                     DateOfSubmission = new DateTime(2021, 03, 04) // Assume correct deadline is 28th
                 },
                 new Assignment()
                 {
                     Id = 4,
                     Name = " Algorithim Sample",
                     Description = "This assignemnt contains some algorithim samplee",
                     StudentId = 4,
                     DateOfSubmission = new DateTime(2021, 02, 28) // Assume correct deadline is 28th
                 }
            );
        }
        //*/

    }
}
