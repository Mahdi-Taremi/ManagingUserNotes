using ManagingUserNotes.API.DataAccess;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Repositoties.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ManagingUserNotes.API.Repositoties.Services
{
    public class NoteRepository : INoteRepository
    {
        private readonly DbContextManagingUserNotes _DbContextManagingUserNotes;
        public NoteRepository(DbContextManagingUserNotes context)
        {
            _DbContextManagingUserNotes = context ?? throw new AggregateException(nameof(context));
        }
        public async Task<IEnumerable<Note>> GetNotesForUserAsync(int userId)
        {
            return await _DbContextManagingUserNotes.Notes.Where(e => e.UserId == userId).ToListAsync();
        }

        public async Task<Note?> GetNoteByIdAsync(int id)
        {
            return await _DbContextManagingUserNotes.Notes.Where(e => e.Id == id).FirstOrDefaultAsync();
        }
    }
}
