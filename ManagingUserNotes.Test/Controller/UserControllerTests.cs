using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagingUserNotes.Test.Controller
{
    public class UserControllerTests
    {
        private readonly Mock<IUserRepository> _userRepository;
        public UserControllerTests()
        {
            _userRepository = new Mock<IUserRepository>();
        }

        // Return a json contains all users without notes
        [Fact]
        // public async Task  CanGetAllUsers_GetUsers_ReturnAJsonContainsAllUsersWithoutNotes() *Async
        // public async void CanGetAllUsers_GetUsers_ReturnAJsonContainsAllUsersWithoutNotes() *Async
        public void CanGetAllUsers_GetUsers_ReturnAJsonContainsAllUsersWithoutNotes()
        {
            // Arrange
            var userListData = GetUserData();
            // _userRepository.Setup(e => e.GetUsers()).ReturnsAsync(userListData); *Async
            _userRepository.Setup(e => e.GetUsers()).Returns(userListData);
            var usersController = new UsersController(_userRepository.Object);

            // Act 
            //var usersResult = await usersController.GetUsers(); *Async
            var usersResult = usersController.GetUsers();

            // Assert 
            Assert.NotNull(usersResult);

        }

        // Return a json contains user with all notes
        [Fact]
        // public async Task CanGetOneUserById_GetUserById_ReturnAJsonContainsUserWithAllNotes() *Async
        // public async void CanGetOneUserById_GetUserById_ReturnAJsonContainsUserWithAllNotes() *Async
        public void CanGetOneUserById_GetUserById_ReturnAJsonContainsUserWithAllNotes()
        {
            // Arrange 
            var userData = GetUserData();
            // _userRepository.Setup(e => e.GetUserById(1, false)).ReturnsAsync(userData[1]); *Async
            _userRepository.Setup(e => e.GetUserById(1, false)).Returns(userData[1]);
            var usersController = new UsersController(_userRepository.Object);

            // Act 
            // var userResult = await usersController.GetUserById(1,true); *Async
            var userResult = usersController.GetUserById(1,true);

            // Assert 
            Assert.NotNull(userResult);
        }

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
