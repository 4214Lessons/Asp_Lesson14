﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lesson10Areas.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "Email")]
    //[Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
