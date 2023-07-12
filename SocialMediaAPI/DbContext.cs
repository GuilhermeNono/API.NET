using Dapper.Contrib.Extensions;
using SocialMediaAPI.Models;
using System.Data;
using System.Data.SqlClient;

namespace SocialMediaAPI
{
    public class DbContext
    {
        private readonly string _connectionString;
        public IDbConnection DbConnection { get; }
        public DbContext(string connectionString)
        {
            DbConnection = new SqlConnection(connectionString);
        }
    }
}
