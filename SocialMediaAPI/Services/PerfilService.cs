using Dapper.Contrib.Extensions;
using SocialMediaAPI.Contracts.Perfil;
using SocialMediaAPI.Models;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Services
{
    public class PerfilService : BaseService, IPerfilService
    {
        List<PerfilResponse> IPerfilService.GetAllPerfils()
        {
            List<PerfilResponse> perfisResult = new List<PerfilResponse>();

            IEnumerable<Perfil> perfis = _connection.GetAll<Perfil>();

            foreach (var perfil in perfis)
            {
                perfisResult.Add(new PerfilResponse(perfil.Nome, perfil.DataNascimento));
            }
            return perfisResult;
        }
    }
}
