using AutoMapper;
using MediatR;
using Net5MediatR.Data.Interfaces;
using Net5MediatR.Data.Model;
using Net5MediatR.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Net5MediatR.Domain.Handler
{
    public class GetClientByIdHandler : IRequestHandler<GetClientByIdRequest, ClientResponse>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public GetClientByIdHandler(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<ClientResponse> Handle(GetClientByIdRequest request, CancellationToken cancellationToken)
        {
            var result = await _clientRepository.GetById(request);
            return _mapper.Map<ClientResponse>(result);
        }
    }
}
