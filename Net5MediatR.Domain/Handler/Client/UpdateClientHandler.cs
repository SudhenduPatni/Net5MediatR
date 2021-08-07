using AutoMapper;
using MediatR;
using Net5MediatR.Data.Interfaces;
using Net5MediatR.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Net5MediatR.Domain.Handler
{
    public class UpdateClientHandler : IRequestHandler<UpdateClientRequest, int>
    {
        private readonly IClientRepository _clientRepository;

        public UpdateClientHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<int> Handle(UpdateClientRequest request, CancellationToken cancellationToken)
        {
            return await _clientRepository.Delete(request);
        }
    }
}
