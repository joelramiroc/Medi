// <copyright file="AgreementBenefitRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class AgreementBenefitRepository : WebApiRepositoryBase<AgreementBenefit>
    {
        public AgreementBenefitRepository(WebApiContext context)
            : base(context)
        {
        }

        public override IQueryable<AgreementBenefit> All()
        {
            return Context.AgreementBenefit;
        }

        protected override AgreementBenefit MapNewValuesToOld(AgreementBenefit oldEntity, AgreementBenefit newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
