// <copyright file="PersonRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Repositories
{
    using System;
    using System.Linq;
    using WebApi.DataBase.Context;
    using WebApi.DataBase.Models;

    public class PersonRepository : WebApiRepositoryBase<Person>
    {
        public PersonRepository(WebApiContext context)
           : base(context)
        {
        }

        public override IQueryable<Person> All()
        {
            return Context.Person;
        }

        protected override Person MapNewValuesToOld(Person oldEntity, Person newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
