using Net5MediatR.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net5MediatR.Data.Interfaces
{
    public interface IClientRepository
    {
        Task<ClientEntity> Add(object paramObj);
        Task<List<ClientEntity>> GetAll();
        Task<ClientEntity> GetById(object paramObj);
        Task<int> Update(object paramObj);
        Task<int> Delete(object paramObj);
    }
}
