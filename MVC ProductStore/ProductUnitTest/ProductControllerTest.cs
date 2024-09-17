using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_ProductStore.Controllers;
using MVC_ProductStore.Models.Entities; // Reference the correct namespace

namespace ProductUnitTest
{
    [TestClass]
    public class ProductControllerTest
    {
        IProductRepository _repository;
        [TestMethod]
        public void IndexReturnsAllProducts()
        {
            // Arrange
            _repository = new FakeProductRepository();
            var controller = new ProductController(_repository);
            // Act
            var result = controller.Index() as ViewResult;
            // Assert
            CollectionAssert.AllItemsAreInstancesOfType((ICollection)result.ViewData.Model,
                typeof(Product));
            Assert.IsNotNull(result, "View Result is null");
            var products = result.ViewData.Model as List<Product>;
            Assert.AreEqual(5, products.Count, "Got wrong number of products");
        }
    }

    public class FakeProductRepository : IProductRepository
    {
    }

    internal interface IProductRepository
    {
    }
}