using AvailityAPI.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AvailityAPI
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
            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "AvailityAPI", Version = "v1" }));
            services.AddDbContext<LoginDetailContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Default")));

            // Cross Origin Resource Sharing: Is a W3C standard that allows a server to relax the same-origin policy.
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.WithOrigins("http://localhost:4200")//(Configuration["WebClients:Availity"])
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
            //services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AvailityAPI v1"));
            }

            //app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();
            //app.UseCors(options =>
            //    options.WithOrigins(_webClientAddress)//("http://localhost:4200")
            //    .AllowAnyHeader()
            //    .AllowAnyMethod());
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
