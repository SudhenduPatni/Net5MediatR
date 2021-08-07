using AutoMapper;
using MediatR;
using Net5MediatR.Data.Entities;
using Net5MediatR.Data.Interfaces;
using Net5MediatR.Data.Model;
using Net5MediatR.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Net5MediatR.Domain.Handler
{
    public class AddClientHandler : IRequestHandler<AddClientRequest, ClientResponse>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public AddClientHandler(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<ClientResponse> Handle(AddClientRequest request, CancellationToken cancellationToken)
        {
            var result = await _clientRepository.Add(request);
            return _mapper.Map<ClientResponse>(result);
        }
    }
}
