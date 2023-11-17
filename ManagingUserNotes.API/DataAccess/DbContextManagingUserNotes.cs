using ManagingUserNotes.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ManagingUserNotes.API.DataAccess
{
    public class DbContextManagingUserNotes : DbContext
    {
        public DbContextManagingUserNotes(DbContextOptions<DbContextManagingUserNotes> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; } = null!; // Use null! For Constructor Entities
        public DbSet<Note> Notes { get; set; } = null!; // Use null! For Constructor Entities

        /* SeedData 1*/
         protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<User>().HasData(
               new User()
               {
                   Id = 1,
                   FirstName = "Mahdi",
                   LastName = "Taremi",
                   Email = "taremiam@gmail.com",
                   Age = 22,
                   Website = "www.mahditaremi.ir"
               },
               new User()
               {
                   Id = 2,
                   FirstName = "Sajjad",
                   LastName = "Taremi",
                   Email = "Test@gmail.com",
                   Age = 28,
                   Website = "www.Test.ir"
               },
               new User()
               {
                   Id = 3,
                   FirstName = "Amir",
                   LastName = "Taremi",
                   Email = "Test2@gmail.com",
                   Age = 32,
                   Website = "www.Test.ir"
               },
               new User()
               {
                   Id = 6,
                   FirstName = "hasan",
                   LastName = "Taremi",
                   Email = "Test3@gmail.com",
                   Age = 42,
                   Website = "www.Test.ir"
               },
               new User()
               {
                   Id = 7,
                   FirstName = "hossein",
                   LastName = "Taremi",
                   Email = "Test4@gmail.com",
                   Age = 52,
                   Website = "www.Test.ir"
               }
               );

           modelBuilder.Entity<Note>().HasData(
               new Note()
               {
                   Id = 1,
                   Content = "This is First Note",
                   DateCreated = DateTime.Now,
                   DateModified = DateTime.Now,
                   Views = 0,
                   Published = true,
                   UserId = 1
               },
               new Note()
               {
                   Id = 2,
                   Content = "This is Second Note",
                   DateCreated = DateTime.Now,
                   DateModified = DateTime.Now,
                   Views = 0,
                   Published = true,
                   UserId = 2
               },
               new Note()
               {
                   Id = 3,
                   Content = "This is Third Note",
                   DateCreated = DateTime.Now,
                   DateModified = DateTime.Now,
                   Views = 0,
                   Published = true,
                   UserId = 1
               },
               new Note()
               {
                   Id = 4,
                   Content = "Test",
                   DateCreated = DateTime.Now,
                   DateModified = DateTime.Now,
                   Views = 0,
                   Published = true,
                   UserId = 1
               },
               new Note()
               {
                   Id = 5,
                   Content = "Test new",
                   DateCreated = DateTime.Now,
                   DateModified = DateTime.Now,
                   Views = 0,
                   Published = true,
                   UserId = 5
               },
               new Note()
               {
                   Id = 6,
                   Content = "Test new",
                   DateCreated = DateTime.Now,
                   DateModified = DateTime.Now,
                   Views = 0,
                   Published = true,
                   UserId = 5
               },
               new Note()
               {
                   Id = 7,
                   Content = "Test new 4",
                   DateCreated = DateTime.Now,
                   DateModified = DateTime.Now,
                   Views = 0,
                   Published = true,
                   UserId = 4
               }
           );
           base.OnModelCreating(modelBuilder);
       } 
        /* SeedData 2*/
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Note>().HasData(
        //        new Note()
        //        {
        //            Id = 1,
        //            Content = "This is First Note",
        //            DateCreated = DateTime.Now,
        //            DateModified = DateTime.Now,
        //            Views = 0,
        //            Published = true,
        //            UserId = 1
        //        },
        //        new Note()
        //        {
        //            Id = 2,
        //            Content = "This is Second Note",
        //            DateCreated = DateTime.Now,
        //            DateModified = DateTime.Now,
        //            Views = 0,
        //            Published = true,
        //            UserId = 2
        //        },
        //        new Note()
        //        {
        //            Id = 3,
        //            Content = "This is Third Note",
        //            DateCreated = DateTime.Now,
        //            DateModified = DateTime.Now,
        //            Views = 0,
        //            Published = true,
        //            UserId = 1
        //        },
        //        new Note()
        //        {
        //            Id = 4,
        //            Content = "Test",
        //            DateCreated = DateTime.Now,
        //            DateModified = DateTime.Now,
        //            Views = 0,
        //            Published = true,
        //            UserId = 1
        //        }
        //        );
        //    base.OnModelCreating(modelBuilder);
        //}
    }


}
