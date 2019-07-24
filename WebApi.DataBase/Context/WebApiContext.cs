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

        public DbSet<AuditsUser> AuditsUser { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<LoginToken> LoginToken { get; set; }

        public DbSet<Person> Person { get; set; }

        public DbSet<Privilege> Privilege { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Adress> Adress { get; set; }

        public DbSet<Telephone> Telephone { get; set; }
    }
}
