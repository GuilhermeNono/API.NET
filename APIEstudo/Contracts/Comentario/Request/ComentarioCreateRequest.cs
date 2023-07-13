namespace SocialMediaAPI.Contracts.Comentario.Request
{
    public record ComentarioCreateRequest(
        string Texto,
        long idPerfil,
        long idPost
        );
}
