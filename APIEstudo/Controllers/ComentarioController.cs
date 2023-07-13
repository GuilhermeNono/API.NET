using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Comentario.Request;
using SocialMediaAPI.Contracts.Comentario.Response;
using SocialMediaAPI.Controllers.Interfaces;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Controllers
{
    [ApiController]
    [Route("comentarios")]
    public class ComentarioController : BaseController<IComentarioService>, IComentarioController
    {
        public ComentarioController(IComentarioService service) : base(service)
        {
        }

        [HttpGet]
        public ActionResult<List<ComentarioResponse>> GetAll()
        {
            try
            {
                return Ok(_service.GetAllComentarios());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ComentarioResponse> GetOne([FromRoute] long id)
        {
            try
            {
                return Ok(_service.GetComentario(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateComentario([FromBody]ComentarioCreateRequest request)
        {
            try
            {
                var comentarioId = _service.CreateComentario(request);

                return Created($"/comentarios/{comentarioId}", request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteComentario([FromRoute] long id)
        {
            try
            {
                _service.DeleteComentario(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<ComentarioUpdatedResponse> UpdateComentario([FromRoute] long id, [FromBody] ComentarioUpdateDataRequest request)
        {
            try
            {
                ComentarioUpdatedResponse response = _service.UpdateComentario(id, request);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
