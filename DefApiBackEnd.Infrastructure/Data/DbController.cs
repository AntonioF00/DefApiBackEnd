using Dapper;
using DefApiBackEnd.Infrastructure.Settings;
using System.Data.Common;

namespace DefApiBackEnd.Infrastructure.Data
{
    public class DbController
    {
        private readonly DbConnection _connection;

        public DbController()
        {
            _connection = ConnectionFactory.GetConnection(Setting.Istance.Configuration.c, Setting.Istance.Configuration.ConnectionString);
        }
        public void ExecuteQuery1(object datas)
        {
            using var connection = _connection;
            connection.Query(Setting.Istance.Configuration.QueryStrings.Query1, datas);
        }
    }
}
