// <copyright file="UserController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApiMed.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        //IUserManager UserManager;

        public UserController()
        {
            //this.UserManager = new UserManager();
        }

        [HttpGet]
        public async Task<ActionResult<object>> GetUser()
        {
            //return (await this.UserManager.GetUser(1));
            return null;
        }
    }
}