// <copyright file="RolRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class RolRepository : WebApiRepositoryBase<Rol>
    {
        public RolRepository(WebApiContext context)
           : base(context)
        {
        }

        public override IQueryable<Rol> All()
        {
            return this.Context.Rol;
        }

        protected override Rol MapNewValuesToOld(Rol oldEntity, Rol newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
