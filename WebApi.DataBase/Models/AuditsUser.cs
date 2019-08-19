// <copyright file="Auditories_user.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AuditsUser
    {
        public int Id { get; set; }

        //[ForeignKey(nameof(User))]
        //public int IdUser { get; set; }

        //public virtual User User { get; set; }

        public DateTime CreationDate { get; set; }

        public string IpAccess { get; set; }

        public string Activity { get; set; }
    }
}
