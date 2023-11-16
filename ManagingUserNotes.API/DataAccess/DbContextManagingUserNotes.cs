using ManagingUserNotes.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ManagingUserNotes.API.DataAccess
{
    public class DbContextManagingUserNotes :DbContext
    {
        public DbContextManagingUserNotes(DbContextOptions<DbContextManagingUserNotes> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; } = null!; // Use null! For Constructor Entities
        public DbSet<Note> Notes { get; set; } = null!; // Use null! For Constructor Entities

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().HasData(
        //        new User()
        //        {
        //            Id = 1,
        //            FirstName = "Mahdi",
        //            LastName = "Taremi",
        //            Email = "taremiam@gmail.com",
        //            Age = 22,
        //            Website = "www.mahditaremi.ir"
        //        },
        //        new User()
        //        {
        //            Id = 2,
        //            FirstName = "Sajjad",
        //            LastName = "Taremi",
        //            Email = "Test@gmail.com",
        //            Age = 28,
        //            Website = "www.Test.ir"
        //        },
        //        new User()
        //        {
        //            Id = 3,
        //            FirstName = "Amir",
        //            LastName = "Taremi",
        //            Email = "Test2@gmail.com",
        //            Age = 32,
        //            Website = "www.Test.ir"
        //        });
        //    base.OnModelCreating(modelBuilder);
        //}
    }


}
