﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SonOfCodWebsite.Models;

namespace SonOfCodWebsite.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManger;

        public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManger = signInManager;
            _db = db;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
