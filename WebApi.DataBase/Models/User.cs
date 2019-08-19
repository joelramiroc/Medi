// <copyright file="User.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(People))]
        public string IdentityPeople { get; set; }

        public virtual Person People { get; set; }

        //[Index("IX_Email", IsUnique = true, Order = 1)]
        public string Email { get; set; }

        //[Index("IX_Username", IsUnique = true, Order = 2)]
        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual ICollection<Privilege> Privileges { get; set; }

        public virtual ICollection<Role> Rols { get; set; }

        public virtual ICollection<AuditsUser> Auditories_user { get; set; }

        public virtual ICollection<LoginToken> LogginToken { get; set; }
    }
}
