using Ticketing._01Core.Domin;
using Ticketing._01Core.Dto;

namespace Ticketing._01Core.Services
{
    public interface ITicketServices
    {
        SimpleTicketDto AddTicket(AddTicketDto model);
        SimpleTicketDto GetTicket(SimpleSearchTicket model);
    }
}
