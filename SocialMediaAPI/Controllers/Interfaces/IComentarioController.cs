using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Comentario.Request;
using SocialMediaAPI.Contracts.Comentario.Response;

namespace SocialMediaAPI.Controllers.Interfaces
{
    public interface IComentarioController
    {
        ActionResult<List<ComentarioResponse>> GetAll();
        ActionResult<ComentarioResponse> GetOne([FromRoute] long id);
        IActionResult CreateComentario([FromBody] ComentarioCreateRequest request);
        IActionResult DeleteComentario([FromRoute] long id);
        ActionResult<ComentarioUpdatedResponse> UpdateComentario([FromRoute] long id, [FromBody] ComentarioUpdateDataRequest request);
    }
}
