namespace ManagingUserNotes.API.Models
{
    public class UserWithoutNotesDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } 
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }
        public string? Website { get; set; }
    }
}
