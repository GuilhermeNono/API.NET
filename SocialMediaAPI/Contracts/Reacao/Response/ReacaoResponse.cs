namespace SocialMediaAPI.Contracts.Reacao.Response
{
    public record ReacaoResponse(
        string Reacoes,
        long PerfilId,
        long PostId);
}
