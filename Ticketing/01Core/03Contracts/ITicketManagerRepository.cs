using Ticketing._01Core.Domin;

namespace Ticketing._01Core._03Contracts
{
    public interface ITicketManagerRepository
    {
        List<Ticket> GetAll();
       
    }
}
