using AutoMapper;
using ManagingUserNotes.API.Entities;
using ManagingUserNotes.API.Models;

namespace ManagingUserNotes.API.Mappings_Profile_
{
    public class NoteProfile : Profile
    {
        public NoteProfile()
        {
            CreateMap<Entities.Note, Models.NoteDto>();
            CreateMap<Entities.Note, Models.NoteWithoutRelationDto>();
        }
}
}
