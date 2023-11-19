using ManagingUserNotes.API.Entities;

namespace ManagingUserNotes.API.Models
{
    public class NoteWithoutRelationDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; } = DateTime.Now;
        public int Views { get; set; }
        public bool Published { get; set; }
        public int UserId { get; set; }


    }
}
