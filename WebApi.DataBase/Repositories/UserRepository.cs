// <copyright file="UserRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class UserRepository : WebApiRepositoryBase<User>
    {
        public UserRepository(WebApiContext context)
           : base(context)
        {
        }

        public override IQueryable<User> All()
        {
            return this.Context.User;
        }

        protected override User MapNewValuesToOld(User oldEntity, User newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
