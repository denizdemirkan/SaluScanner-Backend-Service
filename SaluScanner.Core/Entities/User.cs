namespace SaluScanner.Core.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public bool IsEmailConfirmed { get; set; }

        public User()
        {
            this.Allergies = new HashSet<Allergen>();
        }

        // Navigations & Relations
        ICollection<Allergen> Allergies { get; set; }
    }
}
