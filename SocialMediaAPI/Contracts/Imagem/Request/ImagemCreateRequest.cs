namespace SocialMediaAPI.Contracts.Imagem.Request
{
    public record ImagemCreateRequest(
        string Caminho,
        long PostId);
}
