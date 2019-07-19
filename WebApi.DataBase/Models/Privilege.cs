// <copyright file="Privilege.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Privilege
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Rol))]
        public int IdRol { get; set; }

        public Rol Rol { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
