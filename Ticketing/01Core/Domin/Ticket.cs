namespace Ticketing._01Core.Domin
{
    public class Ticket
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
