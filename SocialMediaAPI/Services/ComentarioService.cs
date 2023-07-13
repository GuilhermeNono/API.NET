using Dapper.Contrib.Extensions;
using SocialMediaAPI.Contracts.Comentario.Request;
using SocialMediaAPI.Contracts.Comentario.Response;
using SocialMediaAPI.Models;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Services
{
    public class ComentarioService : BaseService, IComentarioService
    {
        public long CreateComentario(ComentarioCreateRequest comentarioRequest)
        {
            var comentario = new Comentario(comentarioRequest.Texto, DateTime.Now, comentarioRequest.idPerfil, comentarioRequest.idPost);

            return _connection.Insert(comentario);
        }

        public void DeleteComentario(long id)
        {
            Comentario comentario = _connection.Get<Comentario>(id) 
                ?? throw new Exception($"O usuario de id {id}, não existe."); ;

            _connection.Delete<Comentario>(comentario);
        }

        public List<ComentarioResponse> GetAllComentarios()
        {
            List<ComentarioResponse> comentariosResponses = new List<ComentarioResponse>();
            IEnumerable<Comentario> comentarios = _connection.GetAll<Comentario>();

            foreach (var comentario in comentarios)
            {
                comentariosResponses.Add(new ComentarioResponse(comentario.Texto, comentario.DataC));
            }

            return comentariosResponses;
        }

        public ComentarioResponse GetComentario(long id)
        {
            Comentario comentario = _connection.Get<Comentario>(id) 
                ?? throw new Exception($"O usuario de id {id}, não existe.");

            ComentarioResponse comentarioResponse = new ComentarioResponse(comentario.Texto, comentario.DataC);

            return comentarioResponse;
        }

        public ComentarioUpdatedResponse UpdateComentario(long comentarioId, ComentarioUpdateDataRequest comentarioRequest)
        {
            Comentario comentario = _connection.Get<Comentario>(comentarioId) 
                ?? throw new Exception($"O usuario de id {comentarioId}, não existe.");

            comentario.Texto = comentarioRequest.Texto;

            var updatedComentario = _connection.Update<Comentario>(comentario);

            var comentarioUpdatedResponse = new ComentarioUpdatedResponse(
                comentario.Id,
                comentario.Texto,
                updatedComentario,
                DateTime.Now);

            return comentarioUpdatedResponse;
        }
    }
}
