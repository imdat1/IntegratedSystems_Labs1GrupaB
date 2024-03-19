namespace Web2.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public int? Price { get; set; }
        public Guid TheatreShowId { get; set; }
        public virtual TheatreShow? TheatreShow { get; set; }

        public string? UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
