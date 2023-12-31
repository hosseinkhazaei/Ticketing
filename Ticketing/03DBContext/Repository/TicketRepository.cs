using Ticketing._01Core._03Contracts;
using Ticketing._01Core.Domin;
using Ticketing._01Core.Dto;

namespace Ticketing._03DBContext.Repository
{
    public class TicketRepository : ITicketRepository
    {
        public Ticket GetTicket(SimpleSearchTicket model)
        {
            var result = new Ticket();
            using (var db = new TicketDbContext())
            {
                result = db.Tickets.FirstOrDefault(s => s.Id == model.TicketId && model.UserId == s.UserId);
            }
            return result;
        }

        public Ticket AddTicket(Ticket model)
        {
            using (var db = new TicketDbContext())
            {
                db.Tickets.Add(model);
                db.SaveChanges();
            }
            return model;
        }
    }
}
