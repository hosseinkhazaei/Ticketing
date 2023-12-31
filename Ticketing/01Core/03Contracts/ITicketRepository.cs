using Ticketing._01Core.Domin;
using Ticketing._01Core.Dto;

namespace Ticketing._01Core._03Contracts
{
    public interface ITicketRepository
    {
        Ticket GetTicket(SimpleSearchTicket model);
        Ticket AddTicket(Ticket model);
    }
}
