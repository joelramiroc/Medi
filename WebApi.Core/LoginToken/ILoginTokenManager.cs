// <copyright file="ILoginTokenManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.Core.LoginToken
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WebApi.DataBase.Models;

    public interface ILoginTokenManager
    {
        Task<IEnumerable<DataBase.Models.LoginToken>> GetAllAsync();

        Task<bool> CreateToken(int idUser, string ipAccess);

        Task<bool> ValidateUser(int idUser);

        Task<bool> ValidateToken(int idToken);

        Task<bool> ValidateToken(string token);
    }
}
