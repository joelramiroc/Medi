// <copyright file="WebApiContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Context
{
    using System.Data.Entity;
    using WebApi.DataBase.Models;

    public class WebApiContext : DbContext
    {
        public WebApiContext()
            : base(nameOrConnectionString: "WebApiConecctionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AuditoriesUser> AuditoriesUser { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<LogginToken> LogginToken { get; set; }

        public DbSet<People> People { get; set; }

        public DbSet<Privilege> Privilege { get; set; }

        public DbSet<Rol> Rol { get; set; }

        public DbSet<User> User { get; set; }
    }
}
