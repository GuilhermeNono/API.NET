using Dapper.Contrib.Extensions;
using SocialMediaAPI.Contracts.Perfil.Request;
using SocialMediaAPI.Contracts.Perfil.Response;
using SocialMediaAPI.Models;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Services
{
    public class PerfilService : BaseService, IPerfilService
    {
        public long CreatePerfil(PerfilCreateRequest perfil)
        {
            Perfil perfilCreated = new Perfil(perfil.name, perfil.dataNascimento);
            return _connection.Insert<Perfil>(perfilCreated);
        }

        public void DeletePerfil(long id)
        {
            Perfil perfil = _connection.Get<Perfil>(id) 
                ?? throw new Exception($"O usuario de id {id}, não existe.");

            _connection.Delete<Perfil>(perfil);
        }

        public List<PerfilResponse> GetAllPerfils()
        {
            List<PerfilResponse> perfisResult = new List<PerfilResponse>();

            IEnumerable<Perfil> perfis = _connection.GetAll<Perfil>();

            foreach (var perfil in perfis)
            {
                perfisResult.Add(new PerfilResponse(perfil.Nome, perfil.DataNascimento));
            }
            return perfisResult;
        }

        public PerfilResponse GetPerfil(long id)
        {
            Perfil perfil = _connection.Get<Perfil>(id) 
                ?? throw new Exception($"O usuario de id {id}, não existe.");

            PerfilResponse response = new PerfilResponse(perfil.Nome, perfil.DataNascimento);

            return response;
        }

        public PerfilUpdatedResponse UpdatePerfil(long perfilId, PerfilUpdateDataRequest updatedPerfil)
        {
            Perfil perfil = _connection.Get<Perfil>(perfilId) 
                ?? throw new Exception($"O usuario de id {perfilId}, não existe.");

            perfil.DataNascimento = updatedPerfil.dataNascimento;

            bool perfilUpdated = _connection.Update<Perfil>(perfil);

            var response = new PerfilUpdatedResponse(
                perfilId,
                perfilUpdated,
                DateTime.Now);

            return response;
        }
    }
}
