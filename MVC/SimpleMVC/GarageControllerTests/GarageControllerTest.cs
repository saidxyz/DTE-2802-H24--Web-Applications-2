using Microsoft.AspNetCore.Mvc;
using Moq;
using SimpleMVC.Controllers;
using SimpleMVC.Models.Entities;
using SimpleMVC.Repository;

namespace GarageControllerTests;

public class GarageControllerTest
{
    // Lager moq av iCarRepository
    // Velger selv data og den skal gi ut
    private readonly Mock<ICarRepository> _mockRepo;
    private readonly GarageController _controller;

    public GarageControllerTest()
    {
        // legger dette inn i en controller
        // Fordi controller bruker repository
        _mockRepo = new Mock<ICarRepository>(); 
        _controller = new GarageController(_mockRepo.Object);
    }
    
    // Index 
    [Fact]
    public void Index_ReturnsAViewResult_WithAListOfCars()
    {
        // Arrange: Works as a setup
        // Lager liste med biler
        var cars = new List<Car> {new Car(), new Car(), new Car(), new Car() };
        // Fra iCarRepository, bruker vi metoden GetAll() og returnerer cars
        _mockRepo.Setup(repo => repo.GetAll()).Returns(cars);

        // Act: call the method from the controller, and keeps the result
        var result = _controller.Index();

        // Assert: Tests the results with expected result
        // Sjekker at controlleren har funka
        var viewResult = Assert.IsType<ViewResult>(result);
        // Sjekker om det har kommet ut modellene vi vill
        var model = Assert.IsAssignableFrom<List<Car>>(viewResult.ViewData.Model);
        // sjekker det ene med det andre om det er lik
        Assert.Equal(4, model.Count);
    }
    
    // Create: GET
    [Fact]
    public void Create_ReturnsAViewResult()
    {
        // Act
        var result = _controller.Create();
        
        // Assert
        Assert.IsType<ViewResult>(result);
        
    }
    
    // Create: POST
    [Fact]
    public void Create_Post_ValidModel_RedirectsToIndex()
    {
        // Arrange
        var car = new Car { CarId = "YN12312", Make = "Toyota", Model = "Corolla", Year = 2000 };
        _mockRepo.Setup(repo => repo.Save(It.IsAny<Car>())).Verifiable();

        // Act
        var result = _controller.Create(car);
        
        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
        _mockRepo.Verify();
        
    }
    
}
    