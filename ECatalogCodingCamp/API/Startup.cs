using API.Context;
using API.Middleware;
using API.Repositories;
using API.Repositories.Data;
using API.Repositories.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
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
            services.AddTokenAuthentication(Configuration);
            services.AddDbContext<MyContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("MyConnection")));

            services.AddScoped<IGenericDapper, GeneralDapper>();
            services.AddScoped<AccountRepository>();
            services.AddScoped<BookRepository>();
            services.AddScoped<ClientRepository>();
            services.AddScoped<CVRepository>();
            services.AddScoped<EducationRepository>();
            services.AddScoped<InterviewRequestRepository>();
            services.AddScoped<JobRoleRepository>();
            services.AddScoped<MajorRepository>();
            services.AddScoped<OrganizationRepository>();
            services.AddScoped<ParameterRepository>();
            services.AddScoped<RoleRepository>();
            services.AddScoped<SkillRepository>();
            services.AddScoped<UniversityRepository>();
            services.AddScoped<UserRepository>();
            services.AddScoped<OrganizationCVRepository>();
            services.AddScoped<SkillCVRepository>();
            services.AddScoped<WorkCVRepository>();
            services.AddScoped<WorkRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
