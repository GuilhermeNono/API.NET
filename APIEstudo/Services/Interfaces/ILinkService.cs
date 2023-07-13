using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Link.Request;
using SocialMediaAPI.Contracts.Link.Response;
using SocialMediaAPI.Contracts.Perfil.Request;
using SocialMediaAPI.Contracts.Perfil.Response;

namespace SocialMediaAPI.Services.Interfaces
{
    public interface ILinkService
    {
        List<LinkResponse> GetLinks();
        LinkResponse GetLink(long id);
        void DeleteLink(long id);
        long CreateLink(LinkCreateRequest linkRequest);
        LinkUpdatedResponse UpdateLink(long linkId, LinkUpdateDataRequest updatedLinkRequest);
    }
}
