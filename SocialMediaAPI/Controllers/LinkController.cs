using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Link.Request;
using SocialMediaAPI.Contracts.Link.Response;
using SocialMediaAPI.Controllers.Interfaces;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Controllers
{
    [ApiController]
    [Route("links")]
    public class LinkController : BaseController<ILinkService>, ILinkController
    {
        public LinkController(ILinkService service) : base(service)
        {
        }

        [HttpGet]
        public ActionResult<List<LinkResponse>> GetAll()
        {
            try
            {
                return Ok(_service.GetLinks());
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<LinkResponse> GetOne([FromRoute] long id)
        {
            try
            {
                return Ok(_service.GetLink(id));
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateLink([FromBody] LinkCreateRequest linkRequest)
        {
            try
            {
                var linkId = _service.CreateLink(linkRequest);

                return Created($"/links/{linkId}", linkRequest);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLink([FromRoute] long id)
        {
            try
            {
                _service.DeleteLink(id);

                return NoContent();
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<LinkUpdatedResponse> UpdateLink([FromRoute]long id, [FromBody]LinkUpdateDataRequest linkUpdatedRequest)
        {
            try
            {
                var updatedLink = _service.UpdateLink(id, linkUpdatedRequest);

                return Ok(updatedLink);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
