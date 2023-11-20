using ManagingUserNotes.API.DataAccess;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Models;
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
        public async Task<IEnumerable<Note?>> GetNotesByUserIdAsync(int UserId)
        {
            return await _DbContextManagingUserNotes.Notes.Where(i => i.UserId == UserId).ToListAsync();

        }

        public async Task<Note?> GetNoteByIdAsync(int id)
        {
            return await _DbContextManagingUserNotes.Notes.Where(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task DeleteNoteByIdAsync(int noteId)
        {
            var entity = await _DbContextManagingUserNotes.Notes.FirstOrDefaultAsync(e => e.Id == noteId);

            if (entity != null)
            {
                _DbContextManagingUserNotes.Notes.Remove(entity);
                await _DbContextManagingUserNotes.SaveChangesAsync();
            }
        }

        public async Task<Note> CreateNoteAsync(Note note)
        {
            _DbContextManagingUserNotes.Notes.Add(note);
            await _DbContextManagingUserNotes.SaveChangesAsync();
            return note;
        }

        public async Task<Note?> UpdateNoteByIdAsync(int noteId, Note note)
        {
            Note existingNote = await _DbContextManagingUserNotes.Notes.FindAsync(noteId);
            existingNote.Content = note.Content;
            existingNote.DateModified = DateTime.Now;
            await _DbContextManagingUserNotes.SaveChangesAsync();
            return existingNote;
        }
        public async Task<int> NewVisit(int noteId)
        {
            Note existingNote = await _DbContextManagingUserNotes.Notes.FindAsync(noteId);
            ++existingNote.Views;
            await _DbContextManagingUserNotes.SaveChangesAsync();
            return existingNote.Views;
        }
    }
}
