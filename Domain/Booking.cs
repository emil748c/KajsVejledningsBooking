using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
