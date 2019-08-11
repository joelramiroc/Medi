// <copyright file="Address.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    public class Address
    {
        public string Number { get; set; }

        [ForeignKey(nameof(Person))]
        public string IdentityPeople { get; set; }

        public Person Person { get; set; }
    }
}
