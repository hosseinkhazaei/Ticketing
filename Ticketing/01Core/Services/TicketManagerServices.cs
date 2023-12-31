using Ticketing._01Core._03Contracts;
using Ticketing._01Core._04Mapper;
using Ticketing._01Core.Dto;

namespace Ticketing._01Core.Services
{
    public class TicketManagerServices : ITicketManagerServices
    {
        private readonly ITicketManagerRepository _ticketManagerRepository;
        public TicketManagerServices(ITicketManagerRepository ticketManagerRepository)
        {
            _ticketManagerRepository = ticketManagerRepository;
        }
        public List<SimpleTicketDto> GetAll()
        {
            var tickets = _ticketManagerRepository.GetAll().ToDto();
            return tickets;
        }
    }
}
