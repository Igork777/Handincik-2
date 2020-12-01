using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise1.Models;
using Hand_In_2.Data;
using Hand_In_2.Data.Impl;
using Hand_In_2.Data.Model;
using Hand_In_2.Data.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace REST_API
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
            ExampleDBContext context = new ExampleDBContext();
            services.AddEntityFrameworkSqlite().AddDbContext<ExampleDBContext>();
            UnitOfWork unitOfWork = new UnitOfWork(context);
            services.AddControllers();
            services.AddScoped<IUserService, InMemoryUserService>(serviceProvider => new InMemoryUserService(unitOfWork));
            services.AddScoped<IAdultsService, AdultService>(serviceProvider => new AdultService(unitOfWork));
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}