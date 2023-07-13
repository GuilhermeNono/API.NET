using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Imagem.Request;
using SocialMediaAPI.Contracts.Imagem.Response;
using SocialMediaAPI.Controllers.Interfaces;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Controllers
{
    [ApiController]
    [Route("imagens")]
    public class ImagemController : BaseController<IImagemService>, IImagemController
    {
        public ImagemController(IImagemService service) : base(service)
        {
        }
        [HttpPost]
        public IActionResult CreateImagem([FromBody] ImagemCreateRequest request)
        {
            try
            {
                var imagemId = _service.CreateImagem(request);
                return Created($"/imagens/{imagemId}", request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteImagem([FromRoute] long id)
        {
            try
            {
                _service.DeleteImagem(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public ActionResult<List<ImagemResponse>> GetAll()
        {
            try
            {
                return Ok(_service.GetImagens());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ImagemResponse> GetOne([FromRoute] long id)
        {
            try
            {
                return Ok(_service.GetImagem(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch("{id}")]
        public ActionResult<ImagemUpdatedResponse> UpdateImagem([FromRoute] long id, [FromBody] ImagemUpdateDataRequest request)
        {
            try
            {
                return Ok(_service.UpdateImagem(id, request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
