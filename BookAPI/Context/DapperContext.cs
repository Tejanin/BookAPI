using MySqlConnector;
using System.Data;


namespace BookAPI.Context
{
    public class DapperContext
    {

        private readonly IConfiguration _configuration;
        private readonly string _sqlConnection;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _sqlConnection = _configuration.GetConnectionString("BookAPI");
        }

        public IDbConnection CreateConnection() => new MySqlConnection(_sqlConnection);
    }
}
