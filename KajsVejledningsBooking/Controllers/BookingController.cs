using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Bookings;
using Application.Queries.Bookings;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KajsVejledningsBooking.Controllers
{
    [Route("api/booking")]
    public class BookingController : ApiController
    {
        public BookingController(IMediator mediator) : base(mediator)
        {

        }
        [HttpGet]
        public async Task<IActionResult> GetAllBookings()
        {
            var bookings = await _mediator.Send(new GetAllBookingsQuery());
            return Ok(bookings);
        }

        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> CreateBooking(CreateBookingCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}