// <copyright file="AgreementBenefits.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class AgreementBenefit
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Agreement))]
        public int IdAgreement { get; set; }

        public Agreement Agreement { get; set; }

        [ForeignKey(nameof(BenefitType))]
        public int IdBenefitType { get; set; }

        public BenefitType BenefitType { get; set; }
    }
}
