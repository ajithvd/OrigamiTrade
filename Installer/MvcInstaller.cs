using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OrigamiTrade.Installer
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddMvc(options =>
                {
                    options.EnableEndpointRouting = false;
                    options.Filters.Add<ValidationFilter>();
                })
                .AddFluentValidation(mvcConfiguration => mvcConfiguration.RegisterValidatorsFromAssemblyContaining<Startup>())
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }
    }
}
