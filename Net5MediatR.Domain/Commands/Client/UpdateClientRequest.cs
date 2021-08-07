using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5MediatR.Domain.Commands
{
    public class UpdateClientRequest : IRequest<int>
    {
        public Guid id { get; set; }
    }
}
