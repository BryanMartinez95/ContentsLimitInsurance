using System.Reflection;
using AutoMapper;
using ContentsLimitInsurance.Data;
using ContentsLimitInsurance.Infrastructure.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ContentsLimitInsurance
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


            services.AddAutoMapper(typeof(Startup).Assembly);
            services.AddControllers();
            ConfigureDatabaseServices(services);
            services.AddDbContext<ContentsLimitContext>(options => options.UseSqlite(Configuration.GetConnectionString("ContentsLimitDatabase")));

            services.AddTransient<IAssetService, AssetService>();
            services.AddTransient<IAssetCategoryService, AssetCategoryService>();
            services.AddSwaggerGen();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        // We have to override this method in our TestStartup, because we want to inject our custom database services
        protected virtual void ConfigureDatabaseServices(IServiceCollection services)
        {
            services.AddDbContext<ContentsLimitContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("ContentsLimitDatabase"),
                    builder => builder.MigrationsAssembly(typeof(Startup).GetTypeInfo().Assembly.GetName().Name)
                ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Enable middleware to serve generated Swagger as a JSON endpoint.
                app.UseSwagger();


                // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
                // specifying the Swagger JSON endpoint.
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Contents Limit Insurance API V1");
                });
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            

            app.UseRouting();


            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";
            
                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
