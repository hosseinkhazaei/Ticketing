using System.ComponentModel.DataAnnotations;

namespace Ticketing._01Core.Dto
{
    public class SimpleUserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
    }
}
