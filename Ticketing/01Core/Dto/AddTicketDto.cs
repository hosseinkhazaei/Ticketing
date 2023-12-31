using System.ComponentModel.DataAnnotations;

namespace Ticketing._01Core.Dto
{
    public class AddTicketDto
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Body { get; set; }
    }
}
