// <copyright file="PrivilegeRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    class PrivilegeRepository : WebApiRepositoryBase<Privilege>
    {
        public PrivilegeRepository(WebApiContext context)
           : base(context)
        {
        }

        public override IQueryable<Privilege> All()
        {
            return this.Context.Privilege;
        }

        protected override Privilege MapNewValuesToOld(Privilege oldEntity, Privilege newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
