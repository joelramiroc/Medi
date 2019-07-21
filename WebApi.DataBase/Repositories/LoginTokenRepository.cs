// <copyright file="LoginTokenRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class LoginTokenRepository : WebApiRepositoryBase<LoginToken>
    {
        public LoginTokenRepository(WebApiContext context)
           : base(context)
        {
        }

        public override IQueryable<LoginToken> All()
        {
            return Context.LoginToken;
        }

        protected override LoginToken MapNewValuesToOld(LoginToken oldEntity, LoginToken newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
