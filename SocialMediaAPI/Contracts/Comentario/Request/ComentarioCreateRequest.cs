namespace SocialMediaAPI.Contracts.Comentario.Request
{
    public record ComentarioCreateRequest(
        string Texto,
        DateTime DataComentario,
        long idPerfil,
        long idPost
        );
}
