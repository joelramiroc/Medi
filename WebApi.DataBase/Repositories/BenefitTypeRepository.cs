// <copyright file="BenefitTypeRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class BenefitTypeRepository : WebApiRepositoryBase<BenefitType>
    {
        public BenefitTypeRepository(WebApiContext context)
            : base(context)
        {
        }

        public override IQueryable<BenefitType> All()
        {
            return Context.BenefitType;
        }

        protected override BenefitType MapNewValuesToOld(BenefitType oldEntity, BenefitType newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
