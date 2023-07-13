using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Link.Request;
using SocialMediaAPI.Contracts.Link.Response;

namespace SocialMediaAPI.Controllers.Interfaces
{
    public interface ILinkController
    {
        ActionResult<List<LinkResponse>> GetAll();
        ActionResult<LinkResponse> GetOne([FromRoute] long id);
        IActionResult CreateLink([FromBody] LinkCreateRequest request);
        IActionResult DeleteLink([FromRoute] long id);
        ActionResult<LinkUpdatedResponse> UpdateLink([FromRoute] long id, [FromBody] LinkUpdateDataRequest request);
    }
}
