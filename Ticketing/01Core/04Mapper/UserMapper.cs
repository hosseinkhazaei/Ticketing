using Ticketing._01Core.Domin;
using Ticketing._01Core.Dto;

namespace Ticketing._01Core._04Mapper
{
    public static class UserMapper
    {
        public static UserDto ToDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Password = user.Password,
                UserName = user.Password
            };
        }
        public static User ToModel(this SimpleUserDto model)
        {
            return new User
            {
                Id = Guid.NewGuid(),
                Password = model.Password,
                UserName = model.Password
            };
        }
    }
}
