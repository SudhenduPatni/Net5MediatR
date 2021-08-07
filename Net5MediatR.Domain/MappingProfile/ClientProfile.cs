using AutoMapper;
using Net5MediatR.Data.Entities;
using Net5MediatR.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5MediatR.Domain.MappingProfile
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<ClientEntity, ClientResponse>();
        }
    }
}
