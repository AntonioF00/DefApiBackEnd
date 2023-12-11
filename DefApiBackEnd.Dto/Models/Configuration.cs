using Microsoft.AspNetCore.Http;
using static DefApiBackEnd.Dto.Enums.Enum;

namespace DefApiBackEnd.Dto.Models
{
    public class Configuration
    {

        private string _connectionString {  get; set; }
        private ConnectionTypes _connectionTypes { get; set; }
        private QueryStrings _queryString { get; set; }

        public string ConnectionString { get => _connectionString; set => _connectionString = value; }
        public ConnectionTypes ConnectionTypes  { get => _connectionTypes; set => _connectionTypes = value; }
        public QueryStrings QueryStrings { get => _queryString; set => _queryString = value; }

    }
}
