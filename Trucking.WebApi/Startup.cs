using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;
using Service.Pattern;
using Trucking.Service;
using static Trucking.Entities.Models.MyDbContext;

namespace Trucking.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        readonly string MyAllowSpecificOrigins = "AllAllOrginis";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var connection = @"Server=.\SQLEXPRESS01; Database = Trucking; Trusted_Connection = True";

            services.AddScoped<DbContext, TruckingDbContext>();

            services.AddDbContext<TruckingDbContext>(options => options.UseSqlServer(connection));

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IUnitOfWorkAsync), typeof(UnitOfWork));

            //services.AddTransient<ITruckService, TruckService>();

            services.Scan(scan => scan
                    .FromAssemblyOf<ITruckService>()
                    .AddClasses(classes => classes.AssignableTo<ITruckService>())
                    .AsImplementedInterfaces()
                    .WithTransientLifetime());
            services.AddTransient<IFreightService, FreightService>();

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }            
            app.UseCors();
            app.UseMvc();
        }


    }
}
