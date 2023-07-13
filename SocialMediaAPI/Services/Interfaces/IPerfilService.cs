using SocialMediaAPI.Contracts.Perfil.Request;
using SocialMediaAPI.Contracts.Perfil.Response;
using SocialMediaAPI.Models;

namespace SocialMediaAPI.Services.Interfaces
{
    public interface IPerfilService
    {
        List<PerfilResponse> GetAllPerfils();
        PerfilResponse GetPerfil(long id);
        void DeletePerfil(long id);
        long CreatePerfil(PerfilCreateRequest perfil);
        PerfilUpdatedResponse UpdatePerfil(long perfilId, PerfilUpdateDataRequest updatedPerfil);
    }
}
