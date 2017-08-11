using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using SonOfCodWebsite.Controllers;
using SonOfCodWebsite.Models;
using Microsoft.AspNetCore.Identity;

namespace SonOfCod.tests.ControllerTests
{
    public class AccountControllerTests
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManger;

        [Fact]
        public void Get_ViewResult_Index_Home_Test()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }

        //[Fact]
        //public void Get_ViewResult_Index_Test()
        //{
            //AccountController controller = new AccountController(_userManager, _signInManger, _db);
            //var result = controller.Index();
            //Assert.IsType<ViewResult>(result);
        //}

        //[Fact]
        //public void Get_ModelList_Index_Test()
        //{
            //AccountController controller = new AccountController(_userManager, _signInManger, _db);
            //IActionResult actionResult = controller.Index();
            //ViewResult indexView = new AccountController(_userManager, _signInManger, _db).Index() as ViewResult;
            //var result = indexView.ViewData.Model;
            //Assert.IsType<List<AccountControllerTests>>(result);
        //}

        [Fact]
        public void Get_ViewResult_Create_Test()
        {
            AccountController controller = new AccountController(_userManager, _signInManger, _db);
            var result = controller.Create();
            Assert.IsType<ViewResult>(result);
        }
    }
}
