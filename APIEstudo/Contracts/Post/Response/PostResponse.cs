namespace SocialMediaAPI.Contracts.Post.Response
{
    public record PostResponse(
        string Titulo,
        string Descricao,
        DateTime DataPost);
}
