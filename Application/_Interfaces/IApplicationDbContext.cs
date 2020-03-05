using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application._Interfaces
{
    public interface IApplicationDbContext
    {
         DbSet<Calendar> Calendars { get; set; }
         DbSet<Booking> Bookings { get; set; }
        int SaveChanges();
    }
}
