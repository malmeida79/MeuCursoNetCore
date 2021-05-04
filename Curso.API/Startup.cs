using Curso.CrossCutting.Uteis;
using Curso.Domain.Contracts.Helpers;
using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Infra.Repositories;
using Curso.Infra.Repositories.Context;
using Curso.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Curso.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

             services.AddDbContext<BancosContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionString")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            services.AddSingleton<IHelperWeb, HelperWeb>();

            services.AddTransient<IBancoService, BancoService>();
            services.AddTransient<IClienteService, ClienteService>();

            services.AddTransient<IBancoRepository, BancoRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
