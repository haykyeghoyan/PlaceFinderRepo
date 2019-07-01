using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlaceFinder.BL.ServiceInterfaces;
using PlaceFinder.BL.Services;
using PlaceFinder.DAL.UoW;
using System.Reflection;

namespace PlaceFinder
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //create default identity model 
            var migrationAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;
            var connectionString = Configuration.GetConnectionString("PlaceFinderContext");
            services.AddDbContext<IdentityDbContext>(opt => opt.UseSqlServer(connectionString, 
                                                            sql => sql.MigrationsAssembly(migrationAssembly)));
            
            services.AddAutoMapper();

            // Dependency Injection
            services.AddSingleton<IUnitOfWork, UnitOfWork>();  //create one instance per application (Singleton)
            services.AddScoped<ICategoryService, CategoryService>(); //create one instance per request (AddScoped) 
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IPlaceService, PlaceService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();

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
            app.UseMvc();
        }
    }
}
