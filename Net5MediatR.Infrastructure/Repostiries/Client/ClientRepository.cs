using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Net5MediatR.Data.Configuration;
using Net5MediatR.Data.Entities;
using Net5MediatR.Data.Interfaces;
using Net5MediatR.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5MediatR.Infrastructure.Repostiries
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        private readonly StoredProcedures _storedProcedures;

        public ClientRepository(IConfiguration configuration, IOptions<StoredProcedures> storedProcedures)
            : base(configuration)
        {
            _storedProcedures = storedProcedures.Value;
        }

        public async Task<ClientEntity> Add(object paramObj)
        {
            return await CallStoredProcedureWithResultAsync<ClientEntity>(_storedProcedures.AddClient, paramObj);
        }

        public async Task<List<ClientEntity>> GetAll()
        {
            var result = await CallStoredProcedureWithResultsAsync<ClientEntity>(_storedProcedures.GetAllClient);
            return result.ToList();
        }

        public async Task<ClientEntity> GetById(object paramObj)
        {
            var result = await CallStoredProcedureWithResultsAsync<ClientEntity>(_storedProcedures.GetClientById, paramObj);
            return result.First();
        }

        public async Task<int> Update(object paramObj)
        {
            return await CallStoredProcedureWithResultAsync<int>(_storedProcedures.UpdateClient, paramObj);
        }

        public async Task<int> Delete(object paramObj)
        {
            return await CallStoredProcedureWithResultAsync<int>(_storedProcedures.DeleteClient, paramObj);
        }
    }
}
