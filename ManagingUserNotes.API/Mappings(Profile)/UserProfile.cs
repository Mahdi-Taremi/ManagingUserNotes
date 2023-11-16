using AutoMapper;

namespace ManagingUserNotes.API.Mappings_Profile_
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Entities.User, Models.UserDto>();
            CreateMap<Entities.User, Models.UserWithoutNotesDto>();
        }
    }
}
