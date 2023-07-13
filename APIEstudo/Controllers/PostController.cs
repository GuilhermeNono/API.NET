using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Post.Request;
using SocialMediaAPI.Contracts.Post.Response;
using SocialMediaAPI.Controllers.Interfaces;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Controllers
{
    [ApiController]
    [Route("posts")]
    public class PostController : BaseController<IPostService>, IPostController
    {
        public PostController(IPostService service) : base(service)
        {
        }

        [HttpGet]
        public ActionResult<List<PostResponse>> GetAll()
        {
            try
            {
                return Ok(_service.GetAllPosts());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<PostResponse> GetOne([FromRoute]long id)
        {
            try
            {
                return Ok(_service.GetPost(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreatePost([FromBody]PostCreateRequest request)
        {
            try
            {
                long newPostId = _service.CreatePost(request);

                return Created($"/posts/{newPostId}", request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePost([FromRoute] long id)
        {
            try
            {
                _service.DeletePost(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<PostUpdatedResponse> UpdatePost([FromRoute]long id, [FromBody]PostUpdateDataRequest request)
        {
            try
            {
                PostUpdatedResponse response = _service.UpdatePost(id, request);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}