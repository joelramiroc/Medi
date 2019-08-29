// <copyright file="LoginTokenManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApi.Core.LoginToken
{
    using Microsoft.IdentityModel.Tokens;
    using Microsoft.VisualStudio.Services.Licensing;
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using WebApi.DataBase.Models;
    using WebApi.DataBase.Repositories;

    public class LoginTokenManager : ILoginTokenManager
    {
        private readonly IRepository<LoginToken> loginTokenRepository;

        public LoginTokenManager(IRepository<LoginToken> loginTokenRepository)
        {
            this.loginTokenRepository = loginTokenRepository;
        }

        public async Task<bool> CreateToken(int idUser, string ipAccess)
        {
            var ClaimsData = new[]
            {
                new Claim("idUser", idUser.ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("qwerty"));
            var sigInCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken
                (
                    issuer: "Mysite.com",
                    audience: "Mysite.com",
                    expires: DateTime.Now.AddMinutes(5),
                    claims: ClaimsData,
                    signingCredentials: sigInCredentials
                );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return true;
            //return new OperationResult(true);
        }

        public Task<IEnumerable<DataBase.Models.LoginToken>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateToken(int idToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateToken(string token)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateUser(int idUser)
        {
            throw new NotImplementedException();
        }
    }
}
