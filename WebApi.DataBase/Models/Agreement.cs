namespace WebApi.DataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;

    public class Agreement
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime CreatedDateAgreement { get; set; }

        public DateTime StartDateAgreement { get; set; }

        [ForeignKey(nameof(PlanType))]
        public int IdPlanType { get; set; }

        public PlanType PlanType { get; set; }

        [ForeignKey(nameof(AgreementState))]
        public int IdAgreementState { get; set; }

        public AgreementState AgreementState { get; set; }

        [ForeignKey(nameof(Client))]
        public int IdClient { get; set; }

        public Client Client { get; set; }

        public ICollection<AgreementBenefit> AgreementBenefits { get; set; }
    }
}
