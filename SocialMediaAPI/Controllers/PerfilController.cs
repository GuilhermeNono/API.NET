using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Perfil.Request;
using SocialMediaAPI.Contracts.Perfil.Response;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Controllers
{

    [ApiController]
    [Route("perfis")]
    public class PerfilController : ControllerBase
    {

        private readonly IPerfilService service;

        public PerfilController(IPerfilService perfilService)
        {
            service = perfilService;
        }

        [HttpGet]
        public ActionResult<List<PerfilResponse>> GetAll()
        {
            try
            {
                return Ok(service.GetAllPerfils());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<PerfilResponse> GetOne([FromRoute] long id)
        {
            try
            {
                PerfilResponse perfil = service.GetPerfil(id);

                if (perfil == null)
                    return NotFound();

                return Ok(perfil);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] PerfilCreateRequest perfil)
        {
            try
            {
                long newPerfilId = service.CreatePerfil(perfil);
                return Created($"/perfis/{newPerfilId}", perfil);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]long id)
        {
            try
            {
                service.DeletePerfil(id);
                return NoContent();
            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<PerfilUpdatedResponse> UpdateDataNascimento([FromRoute] long id, [FromBody]PerfilUpdateDateRequest request)
        {
            try
            {
                PerfilUpdatedResponse perfil = service.UpdatePerfil(id, request);
                return Ok(perfil);
            } catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }

    }
}
