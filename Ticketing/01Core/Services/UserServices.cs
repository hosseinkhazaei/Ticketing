using Ticketing._01Core._03Contracts;
using Ticketing._01Core._04Mapper;
using Ticketing._01Core.Dto;

namespace Ticketing._01Core.Services
{

    public class UserServices : IUserServices
    {
        IUserRepository _userRepository;
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public UserDto Register(SimpleUserDto model)
        {
            var user = model.ToModel();
            return _userRepository.Register(user).ToDto();
        }

        public UserDto Login(SimpleUserDto model)
        {
            var result = _userRepository.Login(model);
            if (result != null)
            {
                return result.ToDto();
            }
            return null;
        }
    }
}


