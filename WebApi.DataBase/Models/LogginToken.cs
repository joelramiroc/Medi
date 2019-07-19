// <copyright file="LogginToken.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class LogginToken
    {
        public string Token { get; set; }

        [ForeignKey(nameof(User))]
        public int Iduser { get; set; }

        public User User { get; set; }

        public DateTime CreationDate { get; set; }

        public string IpAccess { get; set; }
    }
}
