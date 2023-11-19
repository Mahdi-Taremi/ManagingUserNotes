using AutoMapper;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Migrations;
using ManagingUserNotes.API.Models;
using ManagingUserNotes.API.Repositoties.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManagingUserNotes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;


        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ?? throw new AggregateException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        #region GetUsers
        [HttpGet]
        [Route("GetUsers")]
        public async Task<ActionResult<IEnumerable<UserWithoutNotesDto>>> GetUsers()
        {
            var users = await _userRepository.GetUsersAsync();
            return Ok(_mapper.Map<IEnumerable<UserWithoutNotesDto>>(users));
        }
        #endregion

        #region GetUser
        [HttpGet]
        [Route("GetUser/{userId}")]
        public async Task<IActionResult> GetUser(int userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<UserWithoutNotesDto>(user));
        }
        #endregion

        #region GetUserIncludeNotes
        [HttpGet]
        [Route("GetUserIncludeNotes/{userId}")]
        public async Task<IActionResult> GetUserIncludeNotes(int userId)
        {
            var user = await _userRepository.GetUserByIdIncludeNotesAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<UserDto>(user));
        }
        #endregion

        #region DeleteUserById
        [HttpDelete]
        [Route("DeleteUserById/{userId}")]
        public async Task<ActionResult> DeleteUserById(int userId)
        {
            var result = await _userRepository.GetUserByIdAsync(userId);

            if (result != null)
            {
                await _userRepository.DeleteUserByIdAsync(userId);
                return Ok("The user was deleted with her notes.");
            }
            return NotFound();

        }
        #endregion

        #region CreateUser
        [HttpPost]
        [Route("CreateUser")]
        public async Task<ActionResult> CreateUser(UserWithDataAnnotationAndWithoutNoteDto user)
        {
            bool isEmailUnique = await _userRepository.IsEmailUnique(user.Email);
            if (!isEmailUnique)
            {
                return BadRequest("Email is pre-existing.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var userResult = _mapper.Map<User>(user);
            var createdUser = await _userRepository.CreateUserAsync(userResult);
            return Ok(_mapper.Map<UserWithoutNotesDto>(createdUser));
        }
        #endregion

    }
}
