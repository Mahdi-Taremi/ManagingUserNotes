using System.ComponentModel.DataAnnotations;

namespace ManagingUserNotes.API.Models
{
    public class NoteUpdateDto
    {
        [Required]
        public string Content { get; set; }
    }
}
