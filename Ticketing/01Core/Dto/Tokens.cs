namespace Ticketing._01Core.Dto
{
    public class Tokens
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public Guid UserId { get; set; }
    }
}
