namespace Ticketing._01Core.Dto
{
    public class SimpleTicketDto
    {
        public Guid UserId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Id { get; set; }
    }
}
