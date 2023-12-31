using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Ticketing._01Core.Dto;
using Ticketing._01Core.Services;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("api/[controller]")]

public class TicketManagerController : ControllerBase
{
    ITicketManagerServices _ticketManagerServices;
    public TicketManagerController(ITicketManagerServices ticketManagerServices)
    {
        _ticketManagerServices = ticketManagerServices;
    }

    [HttpPost]
    [Route("GetAllTicket")]
    public IActionResult GetAllTicket()
    {
        try
        {
            var ticket = _ticketManagerServices.GetAll();
            return Ok(ticket);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }



}