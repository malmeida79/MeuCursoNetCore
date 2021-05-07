using Curso.CrossCutting.Uteis;
using Curso.Domain.Contracts.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace Curso.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddHttpClient();
                services.AddSingleton<FrmBanco>();
                services.AddSingleton<FrmPrincipal>();
                services.AddScoped<IHelperWeb, HelperWeb>();
            });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    var frmPrincipal = services.GetRequiredService<FrmPrincipal>();

                    Application.Run(frmPrincipal);
                }
                catch (Exception ex)
                {
                    Msgs.Erro($"Ocorreu erro de injeção:{ex.Message}");
                    throw;
                }
            }
        }
    }
}
