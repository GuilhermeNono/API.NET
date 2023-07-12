using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc;
using SocialMediaAPI.Contracts.Perfil;
using SocialMediaAPI.Models;
using SocialMediaAPI.Services.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace SocialMediaAPI.Controllers
{

    [ApiController]
    [Route("perfis")]
    public class PerfilController: ControllerBase
    {

    private readonly IPerfilService service;

        public PerfilController(IPerfilService perfilService)
        {
            service = perfilService;
        }

        [HttpGet]
        public ActionResult<List<PerfilResponse>> Get()
        {
            try
            {
                return Ok(service.GetAllPerfils());
            } catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }

    }
}
