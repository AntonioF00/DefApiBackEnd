using Npgsql;
using System.Data.Common;
using System.Data.SqlClient;
using static DefApiBackEnd.Dto.Enums.Enum;

namespace DefApiBackEnd.Infrastructure.Data
{
    public class ConnectionFactory
    {
        public static DbConnection GetConnection(ConnectionTypes type, String connectionString)
        {
            DbConnection _connection = null;

            if (type == ConnectionTypes.POSTGRESQL)
            {
                _connection = new NpgsqlConnection(connectionString);
            }
            else if (type == ConnectionTypes.SQLSERVER)
            {
                _connection = new SqlConnection(connectionString);
            }
            else
            {
                _connection = null;
            }
            return _connection;
        }
        public static DbCommand GetCommandCom(string query, DbConnection conn)
        {
            DbCommand cmd;
            if (conn is NpgsqlConnection nc)
            {
                cmd = new NpgsqlCommand(query, nc);
                return cmd;
            }
            else if (conn is SqlConnection sc)
            {
                cmd = new SqlCommand(query, sc);
                return cmd;
            }
            else
            {
                return null;
            }
        }
        public static int CloseConnection(DbConnection conn)
        {
            conn.Close();
            return (0);
        }
    }
}
