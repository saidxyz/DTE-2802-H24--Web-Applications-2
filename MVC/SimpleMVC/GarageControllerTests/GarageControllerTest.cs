using Microsoft.AspNetCore.Mvc;
using Moq;
using SimpleMVC.Controllers;
using SimpleMVC.Models.Entities;
using SimpleMVC.Repository;

namespace GarageControllerTests;

public class GarageControllerTest
{
    private readonly Mock<ICarRepository> _mockRepo;
    private readonly GarageController _controller;

    public GarageControllerTest()
    {
        _mockRepo = new Mock<ICarRepository>();
        _controller = new GarageController(_mockRepo.Object);
    }
    
    // Index 
    [Fact]
    public void Index_ReturnsAViewResult_WithAListOfCars()
    {
        // Arrange: Works as a setup
        var cars = new List<Car> {new Car(), new Car(), new Car(), new Car()};
        _mockRepo.Setup(repo => repo.GetAll()).Returns(cars);

        // Act: call the method from the controller, and keeps the result
        var result = _controller.Index();

        // Assert: Tests the results with expected result
        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsAssignableFrom<List<Car>>(viewResult.ViewData.Model);
        Assert.Equal(4, model.Count);
    }
}
    