using ComoFazerCrud.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // No método ConfigureServices do seu arquivo Startup.cs
    public void ConfigureServices(IServiceCollection services)
    {
        // Configuração do DbContext para o contexto ComoFazerCrudContext
        services.AddDbContext<ComoFazerCrudContext>(options =>
        {
            var connectionString = Configuration.GetConnectionString("ComoFazerCrudContext");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });

        // Outros serviços
        services.AddControllersWithViews();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Configuração do pipeline de solicitação HTTP

        // Se o ambiente não for de desenvolvimento, configura o tratamento de exceção e HSTS
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        // Redirecionamento HTTPS e uso de arquivos estáticos
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        // Roteamento de solicitação e autorização
        app.UseRouting();
        app.UseAuthorization();

        // Mapeia a rota padrão do controlador
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
