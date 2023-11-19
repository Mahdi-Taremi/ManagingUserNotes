using ManagingUserNotes.API.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ManagingUserNotes.API.Models
{
    public class NoteWithDataAnnotationAndWithoutRelationDto
    {
        [Required]
        public string Content { get; set; } 

        [Required]
        // DataType(DataType.Date)] Validation N/A
        public DateTime? DateCreated { get; set; } 

        [Required]
        // DataType(DataType.Date)] Validation N/A
        public DateTime? DateModified { get; set; } 

        [Required]
        public int Views { get; set; }

        [Required]
        public bool Published { get; set; }

        // Relation with user --> 1
        //[ForeignKey("UserId")]
        [Required]
        public int UserId { get; set; }
    }
}
