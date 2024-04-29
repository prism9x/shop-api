using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Infrastructure.Dapper
{
    public interface IDapperHelper<T> where T : class
    {
        Task ExecuteNotReturn(string query, DynamicParameters parameters = null, IDbTransaction dbTransaction = null);
        Task<T> ExecuteReturnScalarAsync<T>(string query, DynamicParameters parammeters = null);
        Task<IEnumerable<T>> ExecuteSqlReturnList<T>(string query, DynamicParameters parameters = null, IDbTransaction dbTransaction = null);
        Task<IEnumerable<T>> ExecuteStoreProcedureReturnList<T>(string query, DynamicParameters parameters = null, IDbTransaction dbTransaction = null);
    }
}
