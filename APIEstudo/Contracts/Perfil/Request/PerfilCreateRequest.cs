namespace SocialMediaAPI.Contracts.Perfil.Request
{
    public record PerfilCreateRequest(
        string name,
        DateTime dataNascimento);
}
