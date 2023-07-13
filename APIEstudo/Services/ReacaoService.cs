using Dapper.Contrib.Extensions;
using SocialMediaAPI.Contracts.Reacao.Request;
using SocialMediaAPI.Contracts.Reacao.Response;
using SocialMediaAPI.Models;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Services
{
    public class ReacaoService : BaseService, IReacaoService
    {
        public long CreateReacao(ReacaoCreateRequest post)
        {
            var newReacao = new Reacao(post.Reacoes, post.PerfilId, post.PostId);

            long reacaoId = _connection.Insert<Reacao>(newReacao);

            return reacaoId;
        }

        public void DeleteReacao(long id)
        {
            Reacao reacao = _connection.Get<Reacao>(id) 
                ?? throw new Exception($"O usuario de id {id}, não existe.");

            _connection.Delete(reacao);
        }

        public List<ReacaoResponse> GetAllReacoes()
        {
            List<ReacaoResponse> reacaoResponses = new List<ReacaoResponse>();
            IEnumerable<Reacao> reacoes = _connection.GetAll<Reacao>();

            foreach (var reacao in reacoes)
            {
                reacaoResponses.Add(new ReacaoResponse(reacao.Reacoes, reacao.IdPerfil, reacao.IdPost));
            }

            return reacaoResponses;
        }

        public ReacaoResponse GetReacao(long id)
        {
            Reacao reacao = _connection.Get<Reacao>(id) 
                ?? throw new Exception($"O usuario de id {id}, não existe.");

            var reacaoResponse = new ReacaoResponse(reacao.Reacoes, reacao.IdPerfil, reacao.IdPost);

            return reacaoResponse;
        }

        public ReacaoUpdatedResponse UpdateReacao(long reacaoId, ReacaoUpdateDataRequest updatedPost)
        {
            Reacao reacao = _connection.Get<Reacao>(reacaoId)
                ?? throw new Exception($"O usuario de id {reacaoId}, não existe.");

            reacao.Reacoes = updatedPost.Reacoes;

            bool updatedReacao = _connection.Update<Reacao>(reacao);

            var reacaoResponse = new ReacaoUpdatedResponse(
                reacao.Id,
                reacao.Reacoes,
                reacao.IdPerfil,
                reacao.IdPost,
                updatedReacao,
                DateTime.Now);

            return reacaoResponse;
        }
    }
}
