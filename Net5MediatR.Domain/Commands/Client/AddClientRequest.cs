using MediatR;
using Net5MediatR.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5MediatR.Domain.Commands
{
    public class AddClientRequest : IRequest<ClientResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public DateTime ModifiedDatetime { get; set; }
    }
}
