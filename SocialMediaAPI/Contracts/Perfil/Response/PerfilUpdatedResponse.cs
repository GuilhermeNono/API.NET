namespace SocialMediaAPI.Contracts.Perfil.Response
{
    public record PerfilUpdatedResponse(
        long id,
        bool updated,
        DateTime updatedAt
        );
}
