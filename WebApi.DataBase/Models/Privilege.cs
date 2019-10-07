// <copyright file="Privilege.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Privilege
    {
        public int Id { get; set; }


        [ForeignKey(nameof(Role))]
        public int IdRole { get; set; }

        public virtual Role Role { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
