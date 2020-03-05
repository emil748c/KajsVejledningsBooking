using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Bookings
{
    public class GetAllBookingsQuery : IRequest<List<BookingViewModel>>
    {
    }
}
