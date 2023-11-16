﻿using AutoMapper;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Models;

namespace ManagingUserNotes.API.Mappings_Profile_
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Entities.User, Models.UserDto>();
            CreateMap<Entities.User, Models.UserWithoutNotesDto>();
            CreateMap<List<User>, NoteDto>();
            CreateMap<UserDto, NoteDto>();
            CreateMap<NoteDto, UserDto>();

        }
    }
}
