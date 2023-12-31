﻿using AutoMapper;
using ManagingUserNotes.API.Controllers;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Models;
using ManagingUserNotes.API.Repositoties.Interfaces;
using ManagingUserNotes.API.Repositoties.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagingUserNotes.Test.Controller
{
    public class NoteControllerTests
    {
        private readonly Mock<INoteRepository> _noteRepository;
        private readonly Mock<IMapper> _mapper;
        private readonly Mock<IUserRepository> _userRepository;

        public NoteControllerTests()
        {
            _noteRepository = new Mock<INoteRepository>();
            _mapper = new Mock<IMapper>();
            _userRepository = new Mock<IUserRepository>();
        }



        // Return a json contains all notes for a user
        #region GetNotesByUserId
        [Fact]
        public async Task CanGetNotesFromAUser_GetNotesByUserId_ReturnAJsonContainsAllNotesForAUser()
        {
            // Arrange 
            var notesData = GetNoteData();
            //_mapper.Setup(m => m.Map<IEnumerable<Note>, List<Note>>(It.IsAny<IEnumerable<Note>>())).Returns(noteData);
            //var notesController = new NotesController(_noteRepository.Object, _mapper.Object);

            _noteRepository.Setup(e => e.GetNotesByUserIdAsync(1)).ReturnsAsync(notesData);
            var notesController = new NotesController(_noteRepository.Object, _mapper.Object, _userRepository.Object);

            // Act 
            var notesResult = await notesController.GetNotesByUserId(1);

            // Assert 
            Assert.NotNull(notesResult);
        }
        #endregion

        // Return a json contains note
        #region GetNoteById
        [Fact]
        public async Task CanGetNoteWithId_GetNoteById_ReturnAJsonContainsNote()
        {
            // Arrange
            var notesData = GetNoteData();
            //_mapper.Setup(m => m.Map<IEnumerable<Note>, List<Note>>(It.IsAny<IEnumerable<Note>>())).Returns(notesData);
            //_noteRepository.Setup(e => e.GetNotesByUserIdAsync(1)).ReturnsAsync(notesData);

            var notesController = new NotesController(_noteRepository.Object, _mapper.Object, _userRepository.Object);


            // Act
            var noteResult = await notesController.GetNoteById(1);


            // Assert
            Assert.NotNull(noteResult);
        }
        #endregion

        // Delete Note With Note By Id
        #region DeleteNoteById
        [Fact]
        public async Task CanDeleteNoteById_DeleteNoteById_DeleteNoteWithNoteId()
        {
            // Arrange
            var notesData = GetNoteDataForDelete();

            //_mapper.Setup(m => m.Map<IEnumerable<Note>, List<Note>>(It.IsAny<IEnumerable<Note>>())).Returns(notesData);
            //var notesController = new NotesController(_noteRepository.Object);
            var notesController = new NotesController(_noteRepository.Object, _mapper.Object, _userRepository.Object);


            // Act
            var result = await notesController.DeleteNoteById(1);

            // Assert
            Assert.NotNull(result);
        }
        #endregion

        #region GetNoteData(Fake)
        private List<Note> GetNoteData()
        {
            List<Note> notesData = new List<Note>
            {
                    new Note
                    {
                        Id = 1,
                        Content ="This is First Note",
                        DateCreated= DateTime.Now,
                        DateModified = DateTime.Now,
                        Views= 0,
                        Published = true,
                        UserId = 1
                    },
                    new Note
                    {
                        Id = 2,
                        Content = "This is Second Note",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        Views = 0,
                        Published = true,
                        UserId = 2
                    },
                    new Note
                    {
                        Id = 3,
                        Content = "This is Third Note",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        Views = 0,
                        Published = true,
                        UserId = 1
                    },
                    new Note
                    {
                        Id = 4,
                        Content = "Test",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        Views = 0,
                        Published = true,
                        UserId = 1
                    }
        };
            return notesData;
        }
        #endregion

        #region GetNoteDataForDelete(Fake)
        private List<Note> GetNoteDataForDelete()
        {
            List<Note> notesData = new List<Note>
            {
                new Note
                {
                    Id = 1,
                    Content ="This is First Note",
                    DateCreated= DateTime.Now,
                    DateModified = DateTime.Now,
                    Views= 0,
                    Published = true,
                    UserId = 1
                },
            };
            return notesData;
        }
        #endregion

    }
}
