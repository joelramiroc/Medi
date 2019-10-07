// <copyright file="Rol.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Role
    {
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int IdUser { get; set; }

        public virtual User User { get; set; }

        public string RoleName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Privilege> Privileges { get; set; }
    }
}
