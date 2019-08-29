// <copyright file="Startup.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApiMed
{
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.IdentityModel.Tokens;
    using System.Text;
    using WebApi.Core.RoleManager;
    using WebApi.Core.UserManager;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;
    using WebApi.DataBase.Repositories;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.asas
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddEntityFrameworkNpgsql().AddDbContext<WebApiContext>(opt =>
                opt.UseNpgsql("Server=localhost;Database=medi;Username=postgres;Password=1;Port=5432"));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateIssuerSigningKey = true,
                     ValidIssuer = "Mysite.com",
                     ValidAudience = "Mysite.com",
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("qwerty"))
                };
            });

            services.AddDbContext<WebApiContext>();
            this.LoadRepositories(services);
            this.LoadManagers(services);
        }

        public void LoadRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<Address>, AddressRepository>();
            services.AddTransient<IRepository<AuditsUser>, AuditsUserRepository>();
            services.AddTransient<IRepository<LoginToken>, LoginTokenRepository>();
            services.AddTransient<IRepository<Person>, PersonRepository>();
            services.AddTransient<IRepository<Privilege>, PrivilegeRepository>();
            services.AddTransient<IRepository<Role>, RolRepository>();
            services.AddTransient<IRepository<Telephone>, TelephoneRepository>();
            services.AddTransient<IRepository<User>, UserRepository>();
        }

        public void LoadManagers(IServiceCollection services)
        {
            //services.Add(new ServiceDescriptor(typeof(IUserManager), new UserManager()));
            services.AddTransient<IRoleManager, RoleManager>();
            services.AddTransient<IUserManager, UserManager>();
            services.AddTransient<IRoleManager, RoleManager>();
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

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}