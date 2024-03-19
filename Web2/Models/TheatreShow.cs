namespace Web2.Models
{
    public class TheatreShow
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Place { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? ShowDate { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }
    }
}
