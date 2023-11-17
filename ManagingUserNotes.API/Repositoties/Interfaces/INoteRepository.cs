using ManagingUserNotes.API.Entities;

namespace ManagingUserNotes.API.Repositoties.Interfaces
{
    public interface INoteRepository
    {
        Task<IEnumerable<Note>> GetNotesByUserIdAsync(int UserId);
        Task<Note?> GetNoteByIdAsync(int id);
        Task DeleteNoteByIdAsync(int noteId);
    }
}
