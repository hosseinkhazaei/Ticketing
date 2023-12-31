using Ticketing._01Core._03Contracts;
using Ticketing._01Core.Domin;
using Ticketing._01Core.Dto;

namespace Ticketing._03DBContext.Repository
{
    public class UserRepository : IUserRepository
    {
        public User Register(User model)
        {
            using (var db = new TicketDbContext())
            {
                db.Users.Add(model);
                db.SaveChanges();
            }
            return model;
        }

        public User Login(SimpleUserDto model)
        {
            var result = new User();
            using (var db = new TicketDbContext())
            {
                result = db.Users.FirstOrDefault(s => s.UserName == model.UserName && s.Password == model.Password);
            }
            return result;
        }
    }
}
