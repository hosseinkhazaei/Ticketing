using Ticketing._01Core.Domin;
using Ticketing._01Core.Dto;

namespace Ticketing._01Core._04Mapper
{
    public static class TicketMapper
    {

        public static List<SimpleTicketDto> ToDto(this List<Ticket> models)
        {
            return models.Select(s => s.ToDto()).ToList();
        }

        public static SimpleTicketDto ToDto(this Ticket model)
        {
            return new SimpleTicketDto
            {
                Body = model.Body,
                Subject = model.Subject,
                UserId = model.UserId,
                Id = model.Id
            };
        }

        public static Ticket ToModel(this AddTicketDto model)
        {
            return new Ticket
            {
                Body = model.Body,
                Subject = model.Subject,
                UserId = model.UserId,
            };
        }
    }
}
