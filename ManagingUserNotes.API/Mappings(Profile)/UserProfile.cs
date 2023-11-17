using AutoMapper;
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
            CreateMap<UserWithoutNotesDto, User>();
            CreateMap<UserWithDataAnnotationAndWithoutNoteDto, User>();
            CreateMap<User, UserWithDataAnnotationAndWithoutNoteDto>();

        }
    }
}
