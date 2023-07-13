namespace SocialMediaAPI.Contracts.Comentario.Response
{
    public record ComentarioUpdatedResponse(
        long id,
        string Texto,
        bool updated,
        DateTime updatedAt
        );
}
