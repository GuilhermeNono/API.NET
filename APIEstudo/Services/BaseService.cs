using SocialMediaAPI.Services.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace SocialMediaAPI.Services
{
    public abstract class BaseService
    {
        protected IDbConnection _connection;

        protected BaseService()
        {
            _connection = new SqlConnection("Server=localhost;Database=RedeSocial;User Id=sa;Password=Guilherme123@;");
        }
    }
}
