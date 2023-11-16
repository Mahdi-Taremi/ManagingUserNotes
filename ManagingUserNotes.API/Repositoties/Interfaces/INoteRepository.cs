using ManagingUserNotes.API.Entities;

namespace ManagingUserNotes.API.Repositoties.Interfaces
{
    public interface INoteRepository
    {
        Task<IEnumerable<Note>> GetNotesForUserAsync(int userId);
        Task<Note?> GetNoteByIdAsync(int id);
    }
}
