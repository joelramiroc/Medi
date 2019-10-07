// <copyright file="UserController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApiMed.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using WebApi.Core.UserManager;

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        IUserManager UserManager;

        public UserController(IUserManager UserManager)
        {
            this.UserManager = UserManager;
        }

        [HttpGet("{idUser}", Name = "GetUser")]
        public async Task<ActionResult<object>> GetUser([FromRoute] int idUser)
        {
            return await this.UserManager.GetUser(idUser);
        }
    }
}