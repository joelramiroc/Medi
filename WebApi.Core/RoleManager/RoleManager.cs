// <copyright file="RoleManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.Core.RoleManager
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using WebApi.DataBase.Models;
    using WebApi.DataBase.Repositories;

    public class RoleManager : IRoleManager
    {
        private readonly UserRepository userRepository;
        private readonly RolRepository roleRepository;

        public RoleManager(RolRepository roleRepository, UserRepository userRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return await this.roleRepository.All().ToListAsync();
        }

        public async Task<IEnumerable<Role>> GetAllWithPrivilegesAsync()
        {
            return await this.roleRepository.All().Include(s => s.Privileges).ToListAsync();
        }

        public async Task<Role> GetRoleByIdAsync(int idRole)
        {
            return await this.roleRepository.FirstOrDefaultAsync(s => s.Id == idRole);
        }

        public async Task<Role> GetRoleByIdWithPrivilegesAsync(int idRole)
        {
            return await this.roleRepository.All().Include(s => s.Privileges).FirstOrDefaultAsync(s => s.Id == idRole);
        }

        public async Task<IEnumerable<Role>> GetRoleByUserIdAsync(int idUser)
        {
            return (await this.userRepository.FirstOrDefaultAsync(s => s.Id == idUser)).Rols;
        }

        public async Task<IEnumerable<Role>> GetRoleWithPrivilegesByUserIdAsync(int idUser)
        {
            var result = (await this.userRepository.FirstOrDefaultAsync(s => s.Id == idUser)).Rols;
            var rols = new List<Role>();
            foreach (var item in result)
            {
                rols.Add(await this.GetRoleByIdWithPrivilegesAsync(item.Id));
            }

            return rols;
        }
    }
}
