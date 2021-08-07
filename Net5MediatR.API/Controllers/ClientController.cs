using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Net5MediatR.Data.Model;
using Net5MediatR.Domain.Commands;
using Net5MediatR.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5MediatR.API.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : BaseController
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IMediator _mediator;

        public ClientController(ILogger<ClientController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClientResponse>>> GetAll()
        {
            return await _mediator.Send(new GetAllClientRequest());
        }

        [HttpGet("{clientId}")]
        public async Task<ActionResult<ClientResponse>> GetById([FromQuery] GetClientByIdRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPost]
        public async Task<ActionResult<ClientResponse>> Add([FromBody] AddClientRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPut("{clientId}")]
        public async Task<ActionResult<int>> Update([FromQuery] UpdateClientRequest request)
        {
            return await _mediator.Send(request);
        }

        public async Task<ActionResult<int>> Delete([FromQuery] DeleteClientRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
