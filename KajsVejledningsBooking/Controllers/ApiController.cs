using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KajsVejledningsBooking.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}