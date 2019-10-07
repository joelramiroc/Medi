// <copyright file="WebApiContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Context
{
    using Microsoft.EntityFrameworkCore;
    using WebApi.DataBase.Models;

    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options)
            : base(options)
        {
        }

        public DbSet<AuditsUser> AuditsUser { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<Person> Person { get; set; }

        public DbSet<Privilege> Privilege { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Telephone> Telephone { get; set; }

        public DbSet<Agreement> Agreement { get; set; }

        public DbSet<AgreementBenefit> AgreementBenefit { get; set; }

        public DbSet<AgreementState> AgreementState { get; set; }

        public DbSet<BenefitType> BenefitType { get; set; }

        public DbSet<PlanType> PlanType { get; set; }

        public DbSet<Receipt> Receipt { get; set; }
    }
}
