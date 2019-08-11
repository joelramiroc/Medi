// <copyright file="RolRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class RolRepository : WebApiRepositoryBase<Role>
    {
        public RolRepository(WebApiContext context)
           : base(context)
        {
        }

        public override IQueryable<Role> All()
        {
            return Context.Role;
        }

        protected override Role MapNewValuesToOld(Role oldEntity, Role newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
