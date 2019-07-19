// <copyright file="UserManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.Core.UserManager
{
    using System;
    using System.Threading.Tasks;
    using WebApi.DataBase.Repositories;

    public class UserManager : IUserManager
    {
        private readonly UserRepository userRepository;

        public UserManager(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<bool> GetUser(int id)
        {
            var result = await this.userRepository.FirstOrDefaultAsync(s => s.Id == id);
            return result != null ? true : false;
        }

        public async Task<bool> GetUserByEmail(string email, string password)
        {
            var result = await this.userRepository.FirstOrDefaultAsync(s => s.Email == email);

            if (result == null)
            {
                throw new NotImplementedException();
            }

            if (result.Password == password)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> GetUserByUsername(string userName, string password)
        {
            var result = await this.userRepository.FirstOrDefaultAsync(s => s.UserName == userName);

            if (result == null)
            {
                throw new NotImplementedException();
            }

            if (result.Password == password)
            {
                return true;
            }

            return false;
        }
    }
}
