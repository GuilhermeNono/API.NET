using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Reacao.Request;
using SocialMediaAPI.Contracts.Reacao.Response;

namespace SocialMediaAPI.Controllers.Interfaces
{
    public interface IReacaoController
    {
        ActionResult<List<ReacaoResponse>> GetAll();
        ActionResult<ReacaoResponse> GetOne([FromRoute] long id);
        IActionResult CreateReacao([FromBody] ReacaoCreateRequest request);
        IActionResult DeleteReacao([FromRoute] long id);
        ActionResult<ReacaoUpdatedResponse> UpdateReacao([FromRoute] long id, [FromBody] ReacaoUpdateDataRequest request);
    }
}
