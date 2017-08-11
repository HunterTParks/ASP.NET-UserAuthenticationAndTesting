using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCodWebsite.Controllers;
using SonOfCodWebsite.Models;
using Xunit;

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
    }
}
