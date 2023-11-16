using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ManagingUserNotes.API.Entities
{
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        // DataType(DataType.Date)] Validation N/A
        public DateTime? DateCreated { get; set; }

        [Required]
        // DataType(DataType.Date)] Validation N/A
        public DateTime? DateModified { get; set; } = DateTime.Now;

        [Required]
        public int Views { get; set; }

        [Required]
        public bool Published { get; set; }

        // Relation with user --> 1
        [ForeignKey("UserId")]
        public User? User { get; set; }

        public int UserId { get; set; }
    }
}
