// <copyright file="IUserManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.Core.UserManager
{
    using System.Threading.Tasks;

    public interface IUserManager
    {
        Task<bool> GetUser(int id);

        Task<bool> GetUserByUsername(string userName, string password);

        Task<bool> GetUserByEmail(string userName, string password);
    }
}
