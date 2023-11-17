using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Models;

namespace ManagingUserNotes.API.Repositoties.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User?> GetUserByIdAsync(int userId, bool includeNotes);

        Task DeleteUserByIdAsync(int userId);
        Task<bool> IsEmailUnique(string email);
        Task<User?> CreateUserAsync(User user);
    }
}
