// <copyright file="AuditsUserRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class AuditsUserRepository : WebApiRepositoryBase<AuditsUser>
    {
        public AuditsUserRepository(WebApiContext context)
           : base(context)
        {
        }

        public override IQueryable<AuditsUser> All()
        {
            return Context.AuditsUser;
        }

        protected override AuditsUser MapNewValuesToOld(AuditsUser oldEntity, AuditsUser newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
