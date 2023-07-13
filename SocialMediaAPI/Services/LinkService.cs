using Dapper.Contrib.Extensions;
using SocialMediaAPI.Contracts.Link.Request;
using SocialMediaAPI.Contracts.Link.Response;
using SocialMediaAPI.Models;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Services
{
    public class LinkService : BaseService, ILinkService
    {
        public long CreateLink(LinkCreateRequest linkRequest)
        {
            var newLink = new Link(linkRequest.Texto, linkRequest.PostId);

            var linkId = _connection.Insert<Link>(newLink);

            return linkId;
        }

        public void DeleteLink(long id)
        {
            Link link = _connection.Get<Link>(id) ?? throw new Exception($"O usuario de id {id}, não existe.");

            _connection.Delete(link);
        }

        public LinkResponse GetLink(long id)
        {
            Link link = _connection.Get<Link>(id);

            var linkResponse = new LinkResponse(link.Texto, link.IdPost);

            return linkResponse;
        }

        public List<LinkResponse> GetLinks()
        {
            var linksResponse = new List<LinkResponse>();
            IEnumerable<Link> links = _connection.GetAll<Link>();

            foreach (Link link in links)
            {
                linksResponse.Add(new LinkResponse(link.Texto, link.IdPost));
            }

            return linksResponse;
        }

        public LinkUpdatedResponse UpdateLink(long linkId, LinkUpdateDataRequest updatedLinkRequest)
        {
            Link link = _connection.Get<Link>(linkId) ?? throw new Exception($"O usuario de id {linkId}, não existe.");

            link.Texto = updatedLinkRequest.Texto;

            var updatedLink = _connection.Update<Link>(link);

            LinkUpdatedResponse linkUpdated = new LinkUpdatedResponse(
                link.Id,
                link.Texto,
                link.IdPost,
                true,
                DateTime.Now);

            return linkUpdated;
        }
    }
}
