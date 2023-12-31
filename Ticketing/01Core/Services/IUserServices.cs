using Ticketing._01Core.Dto;

namespace Ticketing._01Core.Services
{
    public interface IUserServices
    {
        UserDto Register(SimpleUserDto model);
        UserDto Login(SimpleUserDto model);
    }
}
