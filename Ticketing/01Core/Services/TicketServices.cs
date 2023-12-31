using Ticketing._01Core._03Contracts;
using Ticketing._01Core._04Mapper;
using Ticketing._01Core.Dto;
using Ticketing._01Core.Services;

namespace Ticketing._01Core.Services
{

    public class TicketServices : ITicketServices
    {
        ITicketRepository _ticketRepository;
        public TicketServices(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public SimpleTicketDto AddTicket(AddTicketDto model)
        {
            var result = _ticketRepository.AddTicket(model.ToModel());
            return result.ToDto();
        }

        public SimpleTicketDto GetTicket(SimpleSearchTicket model)
        {
            var ticket = _ticketRepository.GetTicket(model);
            if (ticket!=null)
            {
                return ticket.ToDto();
            }
            return null;
        }
    }
}


