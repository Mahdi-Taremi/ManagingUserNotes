﻿using Moq;
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
        private readonly Mock<IMapper> _mapper;

        public UserControllerTests()
        {
            _userRepository = new Mock<IUserRepository>();
            _mapper = new Mock<IMapper>();
        }

        // Return a json contains all users without notes
        #region GetUsers
        [Fact]
        public async Task CanGetAllUsers_GetUsers_ReturnAJsonContainsAllUsersWithoutNotes()
        {
            // Arrange
            var userListData = GetUserData();
            _mapper.Setup(m => m.Map<IEnumerable<User>, List<User>>(It.IsAny<IEnumerable<User>>())).Returns(userListData);
            var usersController = new UsersController(_userRepository.Object, _mapper.Object);

            // Act 
            var usersResult = await usersController.GetUsers();
            //var testType = usersResult.GetType().ToString();

            // Assert 
            Assert.NotNull(usersResult);
            //Assert.Equal(StatusCodes.Status200OK, usersResult.ContentType);
            //Assert.Equal(testType,"application/json");
        }
        #endregion


        // Return a json contains user with all notes
        #region GetUser
        [Fact]
        public async Task CanGetOneUserById_GetUserById_ReturnAJsonContainsUserWithAllNotes()
        {
            // Arrange 
            var userData = GetUserData();
            _mapper.Setup(m => m.Map<IEnumerable<User>, List<User>>(It.IsAny<IEnumerable<User>>())).Returns(userData);
            var usersController = new UsersController(_userRepository.Object, _mapper.Object);

            // Act 
            var userResult = await usersController.GetUser(1, false);

            // Assert 
            Assert.NotNull(userResult);
        }
        #endregion

        // Delete User With All Notes
        #region DeleteUser
        [Fact]
        public async Task CanDeleteOneUserById_DeleteUserById_DeleteUserWithAllNotes()
        {
            // Arrange 
            var userData = GetUserDataForDelete();
            _mapper.Setup(m => m.Map<IEnumerable<User>, List<User>>(It.IsAny<IEnumerable<User>>())).Returns(userData);
            var usersController = new UsersController(_userRepository.Object, _mapper.Object);

            // Act 
            var userResult = await usersController.DeleteUserById(1);

            // Assert 
            Assert.Null(userResult);
        }
        #endregion


        #region GetUserData(Fake)
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
        #endregion

        #region GetUserDataForDelete(Fake)
        private List<User> GetUserDataForDelete()
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
            };
            return usersData;
        }
        #endregion


    }
}
