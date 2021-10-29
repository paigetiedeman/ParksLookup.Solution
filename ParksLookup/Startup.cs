using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using System.IO;
using ParksLookup.Models;

namespace ParksLookup
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<ParksLookupContext>(opt =>
      opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
            services.AddControllers();
      services.AddSwaggerGen(c =>
            {
              c.SwaggerDoc("v1", new OpenApiInfo
              {
                Version = "v1", 
                Title = "National Parks API",
                Description = "An API containing information on National Parks",
                TermsOfService = new Uri("https://example.com/terms"),
                Contact = new OpenApiContact
                {
                  Name = "Paige Tiedeman",
                  Email = string.Empty,
                  Url = new Uri("https://github.com/paigetiedeman"),
                },
                License = new OpenApiLicense
                {
                  Name = "Use under LICX",
                  Url = new Uri("https://example.com/license"),
                }
              });
            });
          }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                  c.SwaggerEndpoint("/swagger/v1/swagger.json", "ParksLookup v1");
                  c.RoutePrefix = string.Empty;
                });
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
