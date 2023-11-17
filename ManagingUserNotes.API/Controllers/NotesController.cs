using AutoMapper;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Models;
using ManagingUserNotes.API.Repositoties.Interfaces;
using ManagingUserNotes.API.Repositoties.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManagingUserNotes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteRepository _noteRepository;
        private readonly IMapper _mapper;

        //public NotesController(INoteRepository noteRepository, IMapper mapper)
        public NotesController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository ?? throw new AggregateException(nameof(noteRepository));
            //_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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
            //return Ok(_mapper.Map<NoteDto>(notes));
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

    }
}
