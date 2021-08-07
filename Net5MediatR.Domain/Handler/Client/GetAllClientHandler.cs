using AutoMapper;
using MediatR;
using Net5MediatR.Data.Entities;
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
    public class GetAllClientHandler : IRequestHandler<GetAllClientRequest, List<ClientResponse>>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public GetAllClientHandler(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<List<ClientResponse>> Handle(GetAllClientRequest request, CancellationToken cancellationToken)
        {
            var result = await _clientRepository.GetAll();
            return _mapper.Map<List<ClientEntity>, List<ClientResponse>>(result);
        }
    }
}
