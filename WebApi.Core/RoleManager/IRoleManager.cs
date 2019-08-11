// <copyright file="IRoleManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.Core.RoleManager
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WebApi.DataBase.Models;

    public interface IRoleManager
    {
        Task<IEnumerable<Role>> GetAllAsync();

        Task<IEnumerable<Role>> GetAllWithPrivilegesAsync();

        Task<Role> GetRoleByIdAsync(int idRole);

        Task<Role> GetRoleByIdWithPrivilegesAsync(int idRole);

        Task<IEnumerable<Role>> GetRoleByUserIdAsync(int idUser);

        Task<IEnumerable<Role>> GetRoleWithPrivilegesByUserIdAsync(int idUser);
    }
}
