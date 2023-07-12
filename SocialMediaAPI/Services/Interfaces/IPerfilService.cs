using SocialMediaAPI.Contracts.Perfil;
using SocialMediaAPI.Models;

namespace SocialMediaAPI.Services.Interfaces
{
    public interface IPerfilService
    {
        //Incluir um DTO como resposta
        List<PerfilResponse> GetAllPerfils();
    }
}
