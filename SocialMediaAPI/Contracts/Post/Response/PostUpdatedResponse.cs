namespace SocialMediaAPI.Contracts.Post.Response
{
    public record PostUpdatedResponse(
        long id,
        string Titulo, 
        string Descricao,
        bool updated,
        DateTime updatedAt);
}
