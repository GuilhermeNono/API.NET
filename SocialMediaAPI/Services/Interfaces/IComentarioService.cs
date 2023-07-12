using SocialMediaAPI.Contracts.Comentario.Request;
using SocialMediaAPI.Contracts.Comentario.Response;

namespace SocialMediaAPI.Services.Interfaces
{
    public interface IComentarioService
    {
        List<ComentarioResponse> GetAllComentarios();
        ComentarioResponse GetComentario(long id);
        void DeleteComentario(long id);
        long CreateComentario(ComentarioCreateRequest perfil);
        ComentarioUpdatedResponse UpdateComentario(long perfilId, ComentarioUpdateDateRequest updatedPerfil);
    }
}
