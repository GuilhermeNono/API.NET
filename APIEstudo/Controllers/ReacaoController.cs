using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Reacao.Request;
using SocialMediaAPI.Contracts.Reacao.Response;
using SocialMediaAPI.Controllers.Interfaces;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Controllers
{
    [ApiController]
    [Route("reacoes")]
    public class ReacaoController : BaseController<IReacaoService>, IReacaoController
    {
        public ReacaoController(IReacaoService service) : base(service)
        {
        }
        [HttpPost]
        public IActionResult CreateReacao([FromBody] ReacaoCreateRequest request)
        {
            try
            {
                var reacaoId = _service.CreateReacao(request);
                return Created($"/reacoes/{reacaoId}", request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteReacao([FromRoute] long id)
        {
            try
            {
                _service.DeleteReacao(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public ActionResult<List<ReacaoResponse>> GetAll()
        {
            try
            {
                return Ok(_service.GetAllReacoes());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{ID}")]
        public ActionResult<ReacaoResponse> GetOne([FromRoute] long id)
        {
            try
            {
                return Ok(_service.GetReacao(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch("{id}")]
        public ActionResult<ReacaoUpdatedResponse> UpdateReacao([FromRoute] long id, [FromBody] ReacaoUpdateDataRequest request)
        {
            try
            {
                var updateReacao = _service.UpdateReacao(id, request);
                return Ok(updateReacao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
