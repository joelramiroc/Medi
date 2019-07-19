// <copyright file="WebApiRepositoryBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using WebApi.DataBase.Context;

    public abstract class WebApiRepositoryBase<TEntity> : RepositoryBase<TEntity, WebApiContext>
         where TEntity : class
    {
        protected WebApiRepositoryBase(WebApiContext context)
            : base(context)
        {
            this.Context = context;
        }
    }
}
