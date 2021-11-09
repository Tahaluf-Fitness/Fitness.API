using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Infra.Common;
using Tahaluf.Fitness.Infra.Repository;
using Tahaluf.Fitness.Infra.Service;

namespace Tahaluf.Fitness.API
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
            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("x",
                builder =>
                {
                    //builder.WithOrigins("http://127.0.0.1:4200", "http://localhost:4200", "https://localhost:4200")
                    // .AllowAnyHeader()
                    // .AllowAnyMethod();

                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });
            services.AddControllers();
            services.AddScoped<IDbContext, DbContext>();
            services.AddScoped<IAboutUsRepository, AboutUsRepository>();
            services.AddScoped<IAboutUsService, AboutUsService>();
            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            services.AddScoped<IAttendanceService, AttendanceService>();
            services.AddScoped<ICompetitionCategoryRepository, CompetitionCategoryRepository>();
            services.AddScoped<ICompetitionCategoryService, CompetitionCategoryService>();
            services.AddScoped<ICompetitionCommentRepository, CompetitionCommentRepository>();
            services.AddScoped<ICompetitionCommentService, CompetitionCommentService>();
            services.AddScoped<ICompetitionRepository, CompetitionRepository>();
            services.AddScoped<ICompetitionService, CompetitionService>();

            ////
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IUserCompetitionRepository, UserCompetitionRepository>();
            services.AddScoped<IUserCompetitionService, UserCompetitionService>();
            services.AddScoped<IUserMessagesRepository, UserMessagesRepository>();
            services.AddScoped<IUserMessageService, UserMessageService>();
            services.AddScoped<IWebSiteInfoRepository, WebSiteInfoRepository>();
            services.AddScoped<IWebSiteInfoService, WebSiteInfoService>();
            services.AddScoped<IJwtRepository, JwtRepository>();
            services.AddScoped<IJwtService, JwtService>();

            /////
            services.AddScoped<IContactUsRepository, ContactUsRepository>();
            services.AddScoped<IContactUsService, ContactUsService>();
            services.AddScoped<ICreditCardRepository, CreditCardRepository>();
            services.AddScoped<ICreditCardService, CreditCardService>();
            services.AddScoped<IDietCategoryRepository, DietCategoryRepository>();
            services.AddScoped<IDietCategoryService, DietCategoryService>();
            services.AddScoped<IDietReportRepository, DietReportRepository>();
            services.AddScoped<IDietReportService, DietReportService>();
            services.AddScoped<IDiseaseRepository, DiseaseRepository>();
            services.AddScoped<IDiseaseService, DiseaseService>();
            services.AddScoped<IMeasurementRepository, MeasurementRepository>();
            services.AddScoped<IMeasurementService, MeasurementService>();

            //////
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IUsersService, UsersService>();

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(y =>
            {
                y.RequireHttpsMetadata = false;
                y.SaveToken = true;
                y.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]")),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();
            app.UseCors("x");
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
