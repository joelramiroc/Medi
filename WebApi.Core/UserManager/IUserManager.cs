// <copyright file="IUserManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.Core.UserManager
{
    using System.Threading.Tasks;
    using WebApi.DataBase.Models;

    public interface IUserManager
    {
        Task<User> GetUser(int id);

        Task<User> GetUserByUsername(string userName, string password);

        Task<User> GetUserByEmail(string userName, string password);
    }
}
