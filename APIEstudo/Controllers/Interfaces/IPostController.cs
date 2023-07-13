using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Post.Request;
using SocialMediaAPI.Contracts.Post.Response;

namespace SocialMediaAPI.Controllers.Interfaces
{
    public interface IPostController
    {
        ActionResult<List<PostResponse>> GetAll();
        ActionResult<PostResponse> GetOne([FromRoute] long id);
        IActionResult CreatePost([FromBody] PostCreateRequest request);
        IActionResult DeletePost([FromRoute] long id);
        ActionResult<PostUpdatedResponse> UpdatePost([FromRoute] long id, [FromBody] PostUpdateDataRequest request);
    }
}
