using AutoMapper;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Models;
using ManagingUserNotes.API.Repositoties.Interfaces;
using ManagingUserNotes.API.Repositoties.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManagingUserNotes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteRepository _noteRepository;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public NotesController(INoteRepository noteRepository, IMapper mapper, IUserRepository userRepository)
        {
            _noteRepository = noteRepository ?? throw new AggregateException(nameof(noteRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userRepository = userRepository ?? throw new ArgumentNullException();
        }

        #region GetNotesByUserId
        [HttpGet]
        [Route("GetNotesByUserId/{userId}")]
        public async Task<IActionResult> GetNotesByUserId(int userId)
        {
            var notes = await _noteRepository.GetNotesByUserIdAsync(userId);
            if (notes.Count() == 0)
            {
                return NotFound();
            }
            return Ok(notes);
        }
        #endregion

        #region GetNoteById
        [HttpGet]
        [Route("GetNoteById/{id}")]
        public async Task<IActionResult> GetNoteById(int id)
        {
            var note = await _noteRepository.GetNoteByIdAsync(id);
            if (note == null)
            {
                return NotFound();
            }
            return Ok(note);
        }
        #endregion

        #region DeleteNoteById
        [HttpDelete]
        [Route("DeleteNoteById/{noteId}")]
        public async Task<ActionResult> DeleteNoteById(int noteId)
        {
            var result = await _noteRepository.GetNoteByIdAsync(noteId);

            if (result != null)
            {
                await _noteRepository.DeleteNoteByIdAsync(noteId);
                return Ok("The note was deleted.");
            }
            return NotFound();

        }
        #endregion

        #region CreateNote
        [HttpPost]
        [Route("CreateNote")]
        public async Task<ActionResult> CreateNote(NoteWithDataAnnotationAndWithoutRelationDto note)
        {
            var user = await _userRepository.GetUserByIdAsync(note.UserId);
            if (user == null)
            {
                return NotFound("Check the user ID and Please try again.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var noteResult = _mapper.Map<Note>(note);
            var createdNote = await _noteRepository.CreateNoteAsync(noteResult);
            return Ok("Done successfully. ID of the created note : " + createdNote.Id);
        }
        #endregion

        #region UpdateNote
        [HttpPut]
        [Route("UpdateNote/{noteId}")]
        public async Task<IActionResult> UpdateNote(int noteId, NoteUpdateDto note)
        {
            var noteValid = await _noteRepository.GetNoteByIdAsync(noteId);
            if (noteValid == null)
            {
                return NotFound();
            }
            var noteResult = _mapper.Map<Note>(note);
            var updatedNote = await _noteRepository.UpdateNoteByIdAsync(noteId, noteResult);
            if (updatedNote == null)
            {
                return NotFound();
            }
            return Ok(updatedNote);
        }
        #endregion


    }
}
