using Microsoft.AspNetCore.Identity;

namespace Web2.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
