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
    }

}
