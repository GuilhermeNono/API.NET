namespace SocialMediaAPI.Contracts.Post.Request
{
    public record PostUpdateDataRequest(
        string? Titulo,
        string? Descricao);
}
