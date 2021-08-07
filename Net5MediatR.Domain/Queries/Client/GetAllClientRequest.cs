using MediatR;
using Net5MediatR.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5MediatR.Domain.Queries
{
    public class GetAllClientRequest : IRequest<List<ClientResponse>>
    {
    }
}
