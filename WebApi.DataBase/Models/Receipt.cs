// <copyright file="Receipt.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Receipt
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Agreement))]
        public int IdAgreement { get; set; }

        public Agreement Agreement { get; set; }

        public int Number { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime DatePayAgreement { get; set; }

        public DateTime DateAgreement { get; set; }

        public bool? Payed { get; set; }
    }
}
