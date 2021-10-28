using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Serilog;
using SList.API.Services;
using SList.API.Services.Interfaces;
using SList.Infrastructure.Factories;
using SList.Domain.Repositories;
using SList.Infrastructure.Context;
using SList.Infrastructure.Repositories;

namespace SList.API
{
    public class Startup
    {
        public Startup(IWebHostEnvironment environment)
        {
            //var env = Environment.GetEnvironmentVariable("APP_SETTINGS_CONF");
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                //.AddJsonFile($"appsettings.{env}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .CreateLogger();

            HostingEnvironment = environment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment HostingEnvironment { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Log.Logger);
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SList.API", Version = "v1" });
            });

            services.AddDbContext<SListContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SListDatabase")));
            services.AddScoped<SListContextFactory>();

            services.AddScoped<IForumRepository, ForumRepository>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();


            services.AddScoped<IRecipeAppService, RecipeAppService>();
            services.AddScoped<IForumAppService, ForumAppService>();
            services.AddScoped<IUserAppService, UserAppService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SList.API v1"));
            }
            UpdateDatabase(app);
            app.UseSerilogRequestLogging();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        private void UpdateDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<SListContext>())
                {
                    Log.Logger.Information("Migrating Database!");
                    context.Database.Migrate();
                    Log.Logger.Information("Migration Complete!");
                }

            }
        }
    }
}
