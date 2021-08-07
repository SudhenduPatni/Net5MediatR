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
    public class DeleteClientHandler : IRequestHandler<DeleteClientRequest, int>
    {
        private readonly IClientRepository _clientRepository;

        public DeleteClientHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<int> Handle(DeleteClientRequest request, CancellationToken cancellationToken)
        {
            return await _clientRepository.Delete(request);
        }
    }
}
