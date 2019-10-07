// <copyright file="Client.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Client
    {
        [Key]
        public string ClientCode { get; set; }

        [ForeignKey(nameof(Person))]
        public int IdentityPeople { get; set; }

        public Person Person { get; set; }

        public string Photo { get; set; }
    }
}
