using CFK_API.Models;
using CFK_API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using System.Text;

namespace CFK_API
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
            services.AddMvc(options =>
            {
                options.InputFormatters.RemoveAt(0);
                options.OutputFormatters.RemoveAt(0);

                options.InputFormatters.Insert(0, new Compute.Input());
                options.OutputFormatters.Insert(0, new Compute.Output());

                options.FormatterMappings
                .SetMediaTypeMappingForFormat("json", MediaTypeHeaderValue.Parse("application/json"));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Add Cors support.
            services.AddCors();

            // Add JWT support.
            var JwtConfig = Configuration.GetSection("JWT");
            var Key = Encoding.UTF8.GetBytes(JwtConfig.Key);
            services.Configure<JWT>(JwtConfig);

            services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(o =>
            {
                o.RequireHttpsMetadata = true;
                o.SaveToken = true;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Key),
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = true,
                    ValidateLifetime = true
                };
            });

            // Add more services here.
            services.AddSingleton<IDbContainer>(Base.Container);
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ITokenService, TokenService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseCors(o => o
                .AllowAnyMethod()
                .AllowAnyOrigin()
                .AllowCredentials()
                );

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
