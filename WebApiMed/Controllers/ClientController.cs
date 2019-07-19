// <copyright file="ClientController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebApiMed.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}