﻿// <copyright file="Address.cs" company="PlaceholderCompany">
// Copyright (c) Joelsa. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    public class Address
    {
        public int Id { get; set; } 

        public string Number { get; set; } 

        [ForeignKey(nameof(Person))]
        public string IdentityPeople { get; set; }

        public virtual Person Person { get; set; }
    }
}
