using MySqlConnector;
using System.Data;


namespace BookAPI.Context
{
    public class DapperContext
    {

        private readonly IConfiguration _configuration;
        private readonly string _sqlConnection;
        public DapperContext(IConfiguration configuration, string sqlConnection)
        {
            _configuration = configuration;
            _sqlConnection = _configuration.GetConnectionString("");
        }

        public IDbConnection CreateConnection() => new MySqlConnection(_sqlConnection);
    }
}
