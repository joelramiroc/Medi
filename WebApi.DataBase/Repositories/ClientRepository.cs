// <copyright file="ClientRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class ClientRepository : WebApiRepositoryBase<Client>
    {
        public ClientRepository(WebApiContext context)
            : base(context)
        {
        }

        public override IQueryable<Client> All()
        {
            return Context.Client;
        }

        protected override Client MapNewValuesToOld(Client oldEntity, Client newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
