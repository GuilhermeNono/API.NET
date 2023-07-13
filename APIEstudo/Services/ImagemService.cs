using Dapper.Contrib.Extensions;
using SocialMediaAPI.Contracts.Imagem.Request;
using SocialMediaAPI.Contracts.Imagem.Response;
using SocialMediaAPI.Models;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Services
{
    public class ImagemService : BaseService, IImagemService
    {
        public List<ImagemResponse> GetImagens()
        {
            List<ImagemResponse> imagensResponse = new List<ImagemResponse>();
            IEnumerable<Imagem> imagens = _connection.GetAll<Imagem>();

            foreach (var imagem in imagens)
            {
                imagensResponse.Add(new ImagemResponse(imagem.Caminho, imagem.IdPost));
            }

            return imagensResponse;
        }

        public ImagemResponse GetImagem(long id)
        {
            Imagem imagem = _connection.Get<Imagem>(id)
                ?? throw new Exception($"O usuario de id {id}, não existe.");

            var imagemResponse = new ImagemResponse(imagem.Caminho, imagem.IdPost);

            return imagemResponse;
        }

        public long CreateImagem(ImagemCreateRequest linkRequest)
        {
            var newImagem = new Imagem(linkRequest.Caminho, linkRequest.PostId);

            long imagemId = _connection.Insert<Imagem>(newImagem);

            return imagemId;
        }

        public void DeleteImagem(long id)
        {
            Imagem imagem = _connection.Get<Imagem>(id)
                ?? throw new Exception($"O usuario de id {id}, não existe.");

            _connection.Delete<Imagem>(imagem);
        }

        public ImagemUpdatedResponse UpdateImagem(long linkId, ImagemUpdateDataRequest updatedImagemRequest)
        {
            Imagem imagem = _connection.Get<Imagem>(linkId) 
                ?? throw new Exception($"O usuario de id {linkId}, não existe.");

            imagem.Caminho = updatedImagemRequest.Caminho;

            bool updatedImagem = _connection.Update<Imagem>(imagem);

            var imagemResponse = new ImagemUpdatedResponse(
                linkId,
                imagem.Caminho,
                imagem.IdPost,
                updatedImagem,
                DateTime.Now);

            return imagemResponse;
        }
    }
}
