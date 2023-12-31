using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Ticketing._01Core.Domin;
using Ticketing._01Core.Dto;
using Ticketing._01Core.Services;

namespace Ticketing.Controllers
{
    [Authorize(Roles = "User")]
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        ITicketServices _ticketServices;
        public TicketController(ITicketServices ticketServices)
        {
            _ticketServices = ticketServices;
        }

        [HttpPost]
        [Route("GetTicket")]
        public IActionResult GetTicket([FromBody] SimpleSearchTicket model)
        {
            try
            {
                var ticket = _ticketServices.GetTicket(model);
                if (ticket == null)
                {
                    return NotFound(model.TicketId);
                }
                return Ok(ticket);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        [Route("AddTicket")]
        public IActionResult AddTicket([FromBody] AddTicketDto model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                var ticket = _ticketServices.AddTicket(model);
                return Created(new Uri(Request.GetEncodedUrl() + "/" + ticket.Id), ticket);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
