using SocialMediaAPI.Infra.Interface;
using SocialMediaAPI.Models;
using System.Data;

namespace SocialMediaAPI.Infra.Repository
{
    public class PerfilRepository : RepositoryBase<Perfil>, IPerfilRepository
    {
        public PerfilRepository(IDbConnection dbContext) : base(dbContext)
        {
        }


    }
}
