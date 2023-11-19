﻿using ManagingUserNotes.API.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ManagingUserNotes.API.Models
{
    public class UserWithDataAnnotationAndWithoutNoteDto
    {
        [Required] [StringLength(128)] public string FirstName { get; set; } = "";
        [StringLength(128)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        public string Email { get; set; } = string.Empty;
        [Required]
        [Range(0, 160, ErrorMessage = "The Age should be between 0 and 160 years.")]
        public int Age { get; set; } = 0;
        // [Url] Validation N/A
        public string? Website { get; set; } = string.Empty;
    }
}
