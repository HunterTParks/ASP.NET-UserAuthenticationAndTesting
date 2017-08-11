using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using SonOfCodWebsite.Controllers;

namespace SonOfCod.tests.ControllerTests
{
    public class AccountControllerTests
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            AccountController controller = new AccountController();
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            AccountController controller = new AccountController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;
            var result = indexView.ViewData.Model;
            Assert.IsType<List<AccountControllerTests>>(result);
        }
    }
}
