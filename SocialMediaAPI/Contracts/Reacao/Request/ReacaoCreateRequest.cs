namespace SocialMediaAPI.Contracts.Reacao.Request
{
    public record ReacaoCreateRequest(
        string Reacoes,
        long PerfilId,
        long PostId);
}
