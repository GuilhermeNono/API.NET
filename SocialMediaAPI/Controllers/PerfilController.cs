using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Perfil.Request;
using SocialMediaAPI.Contracts.Perfil.Response;
using SocialMediaAPI.Controllers.Interfaces;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Controllers
{

    [ApiController]
    [Route("perfis")]
    public class PerfilController : BaseController<IPerfilService>, IPerfilController
    {
        public PerfilController(IPerfilService service) : base(service)
        {
        }

        [HttpGet]
        public ActionResult<List<PerfilResponse>> GetAll()
        {
            try
            {
                return Ok(_service.GetAllPerfils());
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
                PerfilResponse perfil = _service.GetPerfil(id);

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
        public IActionResult CreatePerfil([FromBody] PerfilCreateRequest perfil)
        {
            try
            {
                long newPerfilId = _service.CreatePerfil(perfil);
                return Created($"/perfis/{newPerfilId}", perfil);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerfil([FromRoute]long id)
        {
            try
            {
                _service.DeletePerfil(id);
                return NoContent();
            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<PerfilUpdatedResponse> UpdatePerfil([FromRoute] long id, [FromBody]PerfilUpdateDataRequest request)
        {
            try
            {
                PerfilUpdatedResponse perfil = _service.UpdatePerfil(id, request);
                return Ok(perfil);
            } catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }

    }
}
