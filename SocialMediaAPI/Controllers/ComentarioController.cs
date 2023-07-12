using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Comentario.Request;
using SocialMediaAPI.Contracts.Comentario.Response;
using SocialMediaAPI.Services.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace SocialMediaAPI.Controllers
{
    [ApiController]
    [Route("comentarios")]
    public class ComentarioController : ControllerBase
    {
        private readonly IComentarioService _service;

        public ComentarioController(IComentarioService service)
        {
            _service = service;
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
        public ActionResult<ComentarioUpdatedResponse> UpdateComentario([FromRoute] long id, [FromBody] ComentarioUpdateDateRequest request)
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
