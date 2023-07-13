using SocialMediaAPI.Contracts.Imagem.Request;
using SocialMediaAPI.Contracts.Imagem.Response;
using SocialMediaAPI.Contracts.Link.Request;
using SocialMediaAPI.Contracts.Link.Response;

namespace SocialMediaAPI.Services.Interfaces
{
    public interface IImagemService
    {
        List<ImagemResponse> GetImagens();
        ImagemResponse GetImagem(long id);
        void DeleteImagem(long id);
        long CreateImagem(ImagemCreateRequest linkRequest);
        ImagemUpdatedResponse UpdateImagem(long linkId, ImagemUpdateDataRequest updatedImagemRequest);
    }
}
