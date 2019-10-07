// <copyright file="People.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        [Key]
        public string Identity { get; set; }

        public string FullName { get; set; }

        public DateTime DateBirth { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Telephone> Telephones { get; set; }

        public virtual ICollection<Address> Adresses { get; set; }
    }
}
