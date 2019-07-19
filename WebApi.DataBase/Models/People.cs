// <copyright file="People.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;

    public class People
    {
        [Key]
        public string Identity { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime DateBirth { get; set; }

        public DateTime Created { get; set; }

        public virtual ObservableCollection<User> Users { get; set; }
    }
}
