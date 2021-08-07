using Dapper;
using Microsoft.Extensions.Configuration;
using Net5MediatR.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5MediatR.Infrastructure.Repostiries
{
    public class BaseRepository
    {
        protected readonly IConfiguration _configuration;

        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentException(nameof(configuration));
        }

        protected void CallStoredProcedure(StoredProcedure storedProcedure, object spData = null)
        {
            var sqlConnectionString = GetConnectionString(storedProcedure);

            using (var conn = new SqlConnection(sqlConnectionString))
            {
                conn.Open();
                conn.Query(storedProcedure.Name, spData, commandTimeout: storedProcedure.Timeout, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        protected async void CallStoredProcedureAsync(StoredProcedure storedProcedure, object spData = null)
        {
            var sqlConnectionString = GetConnectionString(storedProcedure);

            using (var conn = new SqlConnection(sqlConnectionString))
            {
                conn.Open();
                await conn.QueryAsync(storedProcedure.Name, spData, commandTimeout: storedProcedure.Timeout, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        protected Type CallStoredProcedureWithResult<Type>(StoredProcedure storedProcedure, object spData = null)
        {
            var sqlConnectionString = GetConnectionString(storedProcedure);

            using (var conn = new SqlConnection(sqlConnectionString))
            {
                conn.Open();
                var result = conn.Query<Type>(storedProcedure.Name, spData, commandTimeout: storedProcedure.Timeout, commandType: System.Data.CommandType.StoredProcedure);
                return result.First();
            }
        }

        protected async Task<Type> CallStoredProcedureWithResultAsync<Type>(StoredProcedure storedProcedure, object spData = null)
        {
            var sqlConnectionString = GetConnectionString(storedProcedure);

            using (var conn = new SqlConnection(sqlConnectionString))
            {
                conn.Open();
                var result = await conn.QueryAsync<Type>(storedProcedure.Name, spData, commandTimeout: storedProcedure.Timeout, commandType: System.Data.CommandType.StoredProcedure);
                return result.First();
            }
        }

        protected IEnumerable<Type> CallStoredProcedureWithResults<Type>(StoredProcedure storedProcedure, object spData = null)
        {
            var sqlConnectionString = GetConnectionString(storedProcedure);

            using (var conn = new SqlConnection(sqlConnectionString))
            {
                conn.Open();
                var result = conn.Query<Type>(storedProcedure.Name, spData, commandTimeout: storedProcedure.Timeout, commandType: System.Data.CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        protected async Task<IEnumerable<Type>> CallStoredProcedureWithResultsAsync<Type>(StoredProcedure storedProcedure, object spData = null)
        {
            var sqlConnectionString = GetConnectionString(storedProcedure);

            using (var conn = new SqlConnection(sqlConnectionString))
            {
                conn.Open();
                var result = await conn.QueryAsync<Type>(storedProcedure.Name, spData, commandTimeout: storedProcedure.Timeout, commandType: System.Data.CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        protected string GetConnectionString(StoredProcedure storedProcedure)
        {
            if (_configuration == null)
            {
                throw new Exception("No configuration found.");
            }

            if (storedProcedure == null && string.IsNullOrEmpty(storedProcedure.Database))
            {
                throw new ArgumentException("No stored procedure object configured.");
            }

            return _configuration[$"ConnectionString:{storedProcedure.Database}"];
        }
    }
}
