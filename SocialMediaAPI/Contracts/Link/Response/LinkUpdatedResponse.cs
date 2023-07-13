namespace SocialMediaAPI.Contracts.Link.Response
{
    public record LinkUpdatedResponse(
        long id,
        string Texto,
        long PostId,
        bool updated,
        DateTime updatedAt);
}
