using ManagingUserNotes.API.DataAccess;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Models;
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

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _DbContextManagingUserNotes.Users.Where(e => e.Id == userId).FirstOrDefaultAsync();
        }
        public async Task<User?> GetUserByIdIncludeNotesAsync(int userId)
        {
            return await _DbContextManagingUserNotes.Users.Include(i => i.Note).Where(i => i.Id == userId).FirstOrDefaultAsync();
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
        public async Task<bool> IsEmailUnique(string email)
        {
            return await _DbContextManagingUserNotes.Users.AllAsync(e => e.Email != email);
        }
        public async Task<User> CreateUserAsync(User user)
        {
            _DbContextManagingUserNotes.Users.Add(user);
            await _DbContextManagingUserNotes.SaveChangesAsync();
            return user;
        }
    }
}
