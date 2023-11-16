using AutoMapper;
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
        //public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new AggregateException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet]
        [Route("GetUsers")]
        public async Task<ActionResult<IEnumerable<UserWithoutNotesDto>>> GetUsers()
        {
            var users = await _userRepository.GetUsersAsync();
            return Ok(_mapper.Map<IEnumerable<UserWithoutNotesDto>>(users));

            //var result = new List<UserDto>();
            //foreach (var user in users)
            //{
            //    result.Add(new UserDto()
            //    {
            //        Id = user.Id,
            //        FirstName = user.FirstName,
            //        LastName = user.LastName,
            //        Email = user.Email,
            //        Age = user.Age,
            //        Website = user.Website,
            //    });
            //}
            //return Ok(result);
        }
    }
}
