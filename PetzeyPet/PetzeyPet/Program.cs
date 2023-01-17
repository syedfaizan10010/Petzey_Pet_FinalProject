using Microsoft.AspNet.OData.Extensions;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using NLog;
//using NLog.Web;
using PetzeyPetBusinessLogic.AutoMapper;
using PetzeyPetData;
using PetzeyPetDomain.Repository;

namespace PetzeyPet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var logger =NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
            

            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.
            //builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

            builder.Services.AddControllers().AddNewtonsoftJson();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IPatient, PatientRepository>();
            builder.Services.AddControllers();
            builder.Services.AddAutoMapper(typeof(AutoMapperPatient).Assembly);    
            builder.Services.AddOData();

            builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            }));

            builder.Services.AddCors();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

            }

            app.UseHttpsRedirection();
            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors(policyName: "CorsPolicy");



            app.UseEndpoints(endpoints =>
            {
                endpoints.EnableDependencyInjection();
                endpoints.Select().OrderBy().Filter().MaxTop(100).SkipToken();
                endpoints.MapControllers();
            });
            app.Run();
        }
           
    }
}
    