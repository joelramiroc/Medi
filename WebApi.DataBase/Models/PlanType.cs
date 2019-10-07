// <copyright file="PlanType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PlanType
    {
        [Key]
        public int Id { get; set; }

        public int CodePlan { get; set; }

        public string Name { get; set; }
    }
}
