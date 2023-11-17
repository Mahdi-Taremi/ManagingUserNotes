using ManagingUserNotes.API.DataAccess;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Repositoties.Interfaces;
using Microsoft.AspNetCore.Mvc;
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

        public async Task DeleteUserByIdAsync(int userId)
        {
            var entity = await _DbContextManagingUserNotes.Users.FirstOrDefaultAsync(e => e.Id == userId);

            if (entity != null)
            {
                _DbContextManagingUserNotes.Users.Remove(entity);
                await _DbContextManagingUserNotes.SaveChangesAsync();
            }
        }
    }
}
