// <copyright file="AddressRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class AddressRepository : WebApiRepositoryBase<Address>
    {
        public AddressRepository(WebApiContext context)
           : base(context)
        {
        }

        public override IQueryable<Address> All()
        {
            return Context.Address;
        }

        protected override Address MapNewValuesToOld(Address oldEntity, Address newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
