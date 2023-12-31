using Ticketing._01Core.Domin;
using Ticketing._01Core.Dto;

namespace Ticketing._01Core._03Contracts
{
    public interface IUserRepository
    {
        User Login(SimpleUserDto model);
        User Register(User model);
    }
}
