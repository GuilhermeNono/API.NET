
using SocialMediaAPI.Contracts.Reacao.Request;
using SocialMediaAPI.Contracts.Reacao.Response;

namespace SocialMediaAPI.Services.Interfaces
{
    public interface IReacaoService
    {
        List<ReacaoResponse> GetAllReacoes();
        ReacaoResponse GetReacao(long id);
        void DeleteReacao(long id);
        long CreateReacao(ReacaoCreateRequest post);
        ReacaoUpdatedResponse UpdateReacao(long perfilId, ReacaoUpdateDataRequest updatedPost);
    }
}
