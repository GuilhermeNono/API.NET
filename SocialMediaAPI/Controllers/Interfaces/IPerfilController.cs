using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Perfil.Request;
using SocialMediaAPI.Contracts.Perfil.Response;

namespace SocialMediaAPI.Controllers.Interfaces
{
    public interface IPerfilController
    {
        ActionResult<List<PerfilResponse>> GetAll();
        ActionResult<PerfilResponse> GetOne([FromRoute] long id);
        IActionResult CreatePerfil([FromBody] PerfilCreateRequest request);
        IActionResult DeletePerfil([FromRoute] long id);
        ActionResult<PerfilUpdatedResponse> UpdatePerfil([FromRoute] long id, [FromBody] PerfilUpdateDataRequest request);
    }
}
