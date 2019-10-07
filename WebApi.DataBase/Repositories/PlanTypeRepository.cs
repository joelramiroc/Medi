// <copyright file="PlanTypeRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class PlanTypeRepository : WebApiRepositoryBase<PlanType>
    {
        public PlanTypeRepository(WebApiContext context)
            : base(context)
        {
        }

        public override IQueryable<PlanType> All()
        {
            return Context.PlanType;
        }

        protected override PlanType MapNewValuesToOld(PlanType oldEntity, PlanType newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
