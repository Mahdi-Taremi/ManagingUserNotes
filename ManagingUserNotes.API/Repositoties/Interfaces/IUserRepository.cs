using ManagingUserNotes.API.Entities;

namespace ManagingUserNotes.API.Repositoties.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User?> GetUserByIdAsync(int userId, bool includeNotes);
    }
}
