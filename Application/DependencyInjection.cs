using Application.Commands.Calendars;
using Application.Queries;
using Application.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IRequestHandler<GetAllCalendarsQuery, List<CalendarViewModel>>, CalendarQueryHandler>();
            services.AddScoped<IRequestHandler<CreateCalendarCommand>, CalendarCommandHandler>();
            return services;
        }
    }
}
