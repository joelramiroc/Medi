// <copyright file="AgreementStateRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class AgreementStateRepository : WebApiRepositoryBase<AgreementState>
    {
        public AgreementStateRepository(WebApiContext context)
            : base(context)
        {
        }

        public override IQueryable<AgreementState> All()
        {
            return Context.AgreementState;
        }

        protected override AgreementState MapNewValuesToOld(AgreementState oldEntity, AgreementState newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
