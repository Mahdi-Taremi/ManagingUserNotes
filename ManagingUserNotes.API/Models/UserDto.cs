﻿namespace ManagingUserNotes.API.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string? Website { get; set; }

        // Relation with note --> N
         public ICollection<NoteDto> Note { get; set; } = new List<NoteDto>();

    }
}
