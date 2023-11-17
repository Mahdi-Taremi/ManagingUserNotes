using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ManagingUserNotes.API.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(128)]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        public string Email { get; set; }
        [Required]
        [Range(0, 160, ErrorMessage = "The Age should be between 0 and 160 years.")]
        public int Age { get; set; }
        // [Url] Validation N/A
        public string? Website { get; set; }

        // Relation with note --> N
        public ICollection<Note> Note { get; set; } = new List<Note>();
    }
}
