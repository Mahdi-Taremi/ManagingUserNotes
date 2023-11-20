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
            CreateMap<Note, NoteWithoutRelationDto>();
            CreateMap<NoteWithoutRelationDto, Note>();
            CreateMap<NoteWithDataAnnotationAndWithoutRelationDto, Note>();
            CreateMap<Note, NoteWithDataAnnotationAndWithoutRelationDto>();
            CreateMap<NoteUpdateDto, Note>();
        }
    }
}
