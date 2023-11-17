using ManagingUserNotes.API.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagingUserNotes.API.Models
{
    public class NoteDto
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; } = DateTime.Now;
        public int Views { get; set; }
        public bool Published { get; set; }

        // Relation with user --> 1
        [ForeignKey("UserId")]
        public UserDto? User { get; set; }

        public int UserId { get; set; }
    }
}
