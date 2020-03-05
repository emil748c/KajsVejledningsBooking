using Application._Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.Bookings
{
    public class BookingCommandHandler : IRequestHandler<CreateBookingCommand>
    {
        public IMapper _mapper;
        public IApplicationDbContext _context;
        public BookingCommandHandler(IMapper mapper, IApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }


        public Task<Unit> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = new Booking()
            {
                To = request.To,
                From = request.From
            };
            var calendar = _context.Calendars.Include(c => c.Bookings).FirstOrDefault(b => b.Id == request.CalendarId);
            calendar.Bookings.Add(booking);
            _context.SaveChanges();

            return Task.FromResult(Unit.Value);
        }
    }
}
