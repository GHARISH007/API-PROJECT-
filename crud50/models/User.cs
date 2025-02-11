using System.ComponentModel.DataAnnotations;

namespace crud50.models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddres { get; set; }
    }
}
