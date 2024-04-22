using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCorta1.src.Extensions
{
    public static class AplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
                IConfiguration config
        ){
            services.AddControllers();
            //add service to datacontext
            /*services.AddDbContext<DataContext>(options =>
                {
                    options.UseSqlite(config.GetConnectionString("DefaultConnection"));
                });*/
            //add service to verifyToken
            /*
            services
                .AddAuthentication()
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(config["TokenKey"] ?? string.Empty)
                        ),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });*/
            //enable the cors
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader();
                    });
            });

            //service to mapping objects
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //with this you can use the repository pattern, else don't run
            

            return services;
         }
    }
}