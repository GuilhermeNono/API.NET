using SocialMediaAPI.Services.Interfaces;
using SocialMediaAPI.Services;

namespace SocialMediaAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureInversionOfControl(this IServiceCollection services)
        {
            #region Perfil
            services.AddScoped<IPerfilService, PerfilService>();
            #endregion
        }
    }
}
