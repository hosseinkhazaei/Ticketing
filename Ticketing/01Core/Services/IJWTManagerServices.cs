using Ticketing._01Core.Dto;

namespace Ticketing._01Core.Services
{
    public interface IJWTManagerServices
    {
        Tokens Authenticate(SimpleUserDto user);

    }
}
