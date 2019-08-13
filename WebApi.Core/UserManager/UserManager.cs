// <copyright file="UserManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.Core.UserManager
{
    using System;
    using System.Threading.Tasks;
    using WebApi.DataBase.Models;
    using WebApi.DataBase.Repositories;

    public class UserManager : IUserManager
    {
        private readonly IRepository<User> userRepository;

        public UserManager(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<User> GetUser(int id)
        {
            return new User
            {
                UserName = "test.com",
                Email = "test@test.com",
            };

            var result = await this.userRepository.FirstOrDefaultAsync(s => s.Id == id);
            return result;
        }

        public async Task<User> GetUserByEmail(string email, string password)
        {
            var result = await this.userRepository.FirstOrDefaultAsync(s => s.Email == email);

            if (result == null)
            {
                throw new NotImplementedException();
            }

            if (result.Password == password)
            {
                return result;
            }

            return null;
        }

        public async Task<User> GetUserByUsername(string userName, string password)
        {
            var result = await this.userRepository.FirstOrDefaultAsync(s => s.UserName == userName);

            if (result == null)
            {
                throw new NotImplementedException();
            }

            if (result.Password == password)
            {
                return result;
            }

            return null;
        }
    }
}
