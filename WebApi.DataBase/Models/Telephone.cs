// <copyright file="Telephone.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Telephone
    {
        public string Number{ get; set; }

        [ForeignKey(nameof(Person))]
        public string IdentityPeople { get; set; }

        public Person Person { get; set; }
    }
}
