namespace SocialMediaAPI.Contracts.Reacao.Response
{
    public record ReacaoUpdatedResponse(
        int id,
        string Reacoes,
        long PerfilId,
        long PostId,
        bool updated,
        DateTime updatedAt);
}
