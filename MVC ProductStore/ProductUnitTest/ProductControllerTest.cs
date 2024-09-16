using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_ProductStore.Controllers; // Reference the correct namespace

namespace ProductUnitTest
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void IndexReturnsNotNullResult()
        {
            // Arrange
            var controller = new HomeController(); // Create instance of the controller

            // Act
            var result = controller.Index() as ViewResult; // Call Index method and cast the result to ViewResult

            // Assert
            Assert.IsNotNull(result, "View Result is null"); // Ensure that the result is not null
        }
    }
}