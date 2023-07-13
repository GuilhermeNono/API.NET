using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Imagem.Request;
using SocialMediaAPI.Contracts.Imagem.Response;

namespace SocialMediaAPI.Controllers.Interfaces
{
    public interface IImagemController
    {
        ActionResult<List<ImagemResponse>> GetAll();
        ActionResult<ImagemResponse> GetOne([FromRoute] long id);
        IActionResult CreateImagem([FromBody] ImagemCreateRequest request);
        IActionResult DeleteImagem([FromRoute] long id);
        ActionResult<ImagemUpdatedResponse> UpdateImagem([FromRoute] long id, [FromBody] ImagemUpdateDataRequest request);
    }
}
