using System.Data;
using Dapper;

namespace PerformanceAnalysis.Infrastructure.Reports
{
    /// <summary>
    /// Реальная реализация -- делегирует вызы Dapper.
    /// </summary>
    public class DapperExecutor : IDapperExecutor
    {
        private readonly IDbConnection _connection;

        public DapperExecutor(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object? param = null)
        {
            return await _connection.QueryAsync<T>(sql, param);
        }

        public async Task<T?> QueryFirstOrDefaultAsync<T>(string sql, object? param = null)
        {
            return await _connection.QueryFirstOrDefaultAsync<T>(sql, param);
        }
    }
}
