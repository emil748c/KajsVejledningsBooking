using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
     public class GetAllCalendarsQuery : IRequest<List<CalendarViewModel>>
    {
    }
}
