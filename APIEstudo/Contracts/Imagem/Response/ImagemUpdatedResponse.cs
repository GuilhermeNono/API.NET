namespace SocialMediaAPI.Contracts.Imagem.Response
{
    public record ImagemUpdatedResponse(
        long id,
        string Caminho,
        long PostId,
        bool updated,
        DateTime updatedAt);
}
