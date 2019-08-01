// <copyright file="TelephoneRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class TelephoneRepository : WebApiRepositoryBase<Telephone>
    {
        public TelephoneRepository(WebApiContext context)
           : base(context)
        {
        }

        public override IQueryable<Telephone> All()
        {
            return Context.Telephone;
        }

        protected override Telephone MapNewValuesToOld(Telephone oldEntity, Telephone newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
