// <copyright file="AgreementRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class AgreementRepository : WebApiRepositoryBase<Agreement>
    {
        public AgreementRepository(WebApiContext context) 
            : base(context)
        {
        }

        public override IQueryable<Agreement> All()
        {
            return Context.Agreement;
        }

        protected override Agreement MapNewValuesToOld(Agreement oldEntity, Agreement newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
