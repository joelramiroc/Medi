// <copyright file="Rol.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.DataBase.Models
{
    using System.Collections.ObjectModel;

    public class Role
    {
        public int Id { get; set; }

        public string RoleName { get; set; }

        public string Description { get; set; }

        public ObservableCollection<Privilege> Privileges { get; set; }

        public ObservableCollection<User> Users { get; set; }
    }
}
