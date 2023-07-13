namespace SocialMediaAPI.Contracts.Post.Request
{
    public record PostCreateRequest(
        string Titulo,
        string Descricao,
        long idPerfil);
}
