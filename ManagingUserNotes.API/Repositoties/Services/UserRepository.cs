using ManagingUserNotes.API.DataAccess;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Repositoties.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ManagingUserNotes.API.Repositoties.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContextManagingUserNotes _DbContextManagingUserNotes;
        public UserRepository(DbContextManagingUserNotes context)
        {
            _DbContextManagingUserNotes = context ?? throw new AggregateException(nameof(context));

        }
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _DbContextManagingUserNotes.Users.ToListAsync();
        }

        public async Task<User?> GetUserByIdAsync(int userId, bool includeNotes)
        {
            if (includeNotes)
            {
                return await _DbContextManagingUserNotes.Users.Include(i => i.Note).Where(i => i.Id == userId).FirstOrDefaultAsync();
            }

            return await _DbContextManagingUserNotes.Users.Where(e => e.Id == userId).FirstOrDefaultAsync();
        }
    }
}
