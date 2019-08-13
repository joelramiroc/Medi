// <copyright file="WebApiContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Context
{
    using java.awt.image;
    using Microsoft.EntityFrameworkCore;
    using WebApi.DataBase.Models;

    public class WebApiContext : DbContext
    {
        public WebApiContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UsePostgreSql(@"host=server;database=test;user id=postgres;");
        }

        public DbSet<AuditsUser> AuditsUser { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<LoginToken> LoginToken { get; set; }

        public DbSet<Person> Person { get; set; }

        public DbSet<Privilege> Privilege { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Telephone> Telephone { get; set; }
    }
}
