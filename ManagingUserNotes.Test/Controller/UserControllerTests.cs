using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagingUserNotes.API.Controllers;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Repositoties.Interfaces;
using AutoMapper;
using ManagingUserNotes.API.Mappings_Profile_;
using ManagingUserNotes.API.Models;
using Microsoft.AspNetCore.Http;

namespace ManagingUserNotes.Test.Controller
{
    public class UserControllerTests
    {
        private readonly Mock<IUserRepository> _userRepository;
        //private readonly IMapper _mapper;
        private readonly Mock<IMapper> _mapper;

        public UserControllerTests()
        {
            _userRepository = new Mock<IUserRepository>();
            //if (_mapper == null)
            //{
            //    var mappingConfig = new MapperConfiguration(mc =>
            //    {
            //        mc.AddProfile(new UserProfile());
            //    });
            //    IMapper mapper = mappingConfig.CreateMapper();
            //    _mapper = mapper;
            //}
            _mapper = new Mock<IMapper>();
        }

        // Return a json contains all users without notes
        [Fact]
        public async Task CanGetAllUsers_GetUsers_ReturnAJsonContainsAllUsersWithoutNotes()
        // public async void CanGetAllUsers_GetUsers_ReturnAJsonContainsAllUsersWithoutNotes() *Async
        // public void CanGetAllUsers_GetUsers_ReturnAJsonContainsAllUsersWithoutNotes()
        {
            // Arrange
            var userListData = GetUserData();
            _mapper.Setup(m => m.Map<IEnumerable<User>,List<User>>(It.IsAny<IEnumerable<User>>())).Returns(userListData);
            //_userRepository.Setup(e => e.GetUsersAsync()).ReturnsAsync(userListData); 
            //_userRepository.Setup(e => e.GetUsersAsync()).Returns(userListData);
            //var usersController = new UsersController(_userRepository.Object);
            var usersController = new UsersController(_userRepository.Object, _mapper.Object);

            // Act 
            var usersResult = await usersController.GetUsers();
            var testType = usersResult.GetType().ToString();

            // Assert 
            Assert.NotNull(usersResult);
            //Assert.Equal(StatusCodes.Status200OK, usersResult.ContentType);
            //Assert.Equal(testType,"application/json");



        }

        //// Return a json contains user with all notes
        //[Fact]
        //// public async Task CanGetOneUserById_GetUserById_ReturnAJsonContainsUserWithAllNotes() *Async
        //// public async void CanGetOneUserById_GetUserById_ReturnAJsonContainsUserWithAllNotes() *Async
        //public void CanGetOneUserById_GetUserById_ReturnAJsonContainsUserWithAllNotes()
        //{
        //    // Arrange 
        //    var userData = GetUserData();
        //    // _userRepository.Setup(e => e.GetUserById(1, false)).ReturnsAsync(userData[1]); *Async
        //    _userRepository.Setup(e => e.GetUserById(1, false)).Returns(userData[1]);
        //    var usersController = new UsersController(_userRepository.Object);

        //    // Act 
        //    // var userResult = await usersController.GetUserById(1,true); *Async
        //    var userResult = usersController.GetUserById(1, true);

        //    // Assert 
        //    Assert.NotNull(userResult);
        //}

        private List<User> GetUserData()
        {
            List<User> usersData = new List<User>
            {
                new User
                {

                    Id = 1,
                    FirstName = "Mahdi",
                    LastName = "Taremi",
                    Email = "taremiam@gmail.com",
                    Age = 22,
                    Website = "www.mahditaremi.ir"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Sajjad",
                    LastName = "Taremi",
                    Email = "Test@gmail.com",
                    Age = 28,
                    Website = "www.Test.ir"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Amir",
                    LastName = "Taremi",
                    Email = "Test2@gmail.com",
                    Age = 32,
                    Website = "www.Test.ir"
                },
            };
            return usersData;
        }
    }
}
