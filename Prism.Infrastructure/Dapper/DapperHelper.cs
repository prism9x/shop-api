using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Infrastructure.Dapper
{
    public class DapperHelper<T> : IDapperHelper<T> where T : class
    {
        private readonly string? connectionString = string.Empty;
        private IDbConnection _dbConnection;
        public DapperHelper(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task ExecuteNotReturn(string query, DynamicParameters parameters = null, IDbTransaction dbTransaction = null)
        {
            using (var dbConnection = new SqlConnection(connectionString))
            {
                await dbConnection.ExecuteAsync(query, parameters, dbTransaction, commandType: CommandType.Text);
            }
        }

        public async Task<T> ExecuteReturnScalarAsync<T>(string query, DynamicParameters parammeters = null)
        {
            using (var dbConnection = new SqlConnection(connectionString))
            {
                return (T)Convert.ChangeType(await dbConnection.ExecuteScalarAsync<T>(query, parammeters,
                                                                commandType: CommandType.StoredProcedure), typeof(T));
            }
        }

        public async Task<IEnumerable<T>> ExecuteSqlReturnList<T>(string query, DynamicParameters parameters = null, IDbTransaction dbTransaction = null)
        {
            using (var dbConnection = new SqlConnection(connectionString))
            {
                return await dbConnection.QueryAsync<T>(query, parameters, dbTransaction, commandType: CommandType.Text);
            }
        }

        public async Task<IEnumerable<T>> ExecuteStoreProcedureReturnList<T>(string query, DynamicParameters parameters = null, IDbTransaction dbTransaction = null)
        {
            using (var dbConnection = new SqlConnection(connectionString))
            {
                return await dbConnection.QueryAsync<T>(query, parameters, dbTransaction, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
