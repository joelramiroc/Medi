// <copyright file="ReceiptRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class ReceiptRepository : WebApiRepositoryBase<Receipt>
    {
        public ReceiptRepository(WebApiContext context)
            : base(context)
        {
        }

        public override IQueryable<Receipt> All()
        {
            return Context.Receipt;
        }

        protected override Receipt MapNewValuesToOld(Receipt oldEntity, Receipt newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
