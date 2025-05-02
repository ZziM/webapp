using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using webapp.api.Controllers;

namespace webapp.UnitTests.Controllers;

[TestFixture]
public class WeatherForecastControllerTests
{
    private WeatherForecastController _controller;
    private ILogger<WeatherForecastController> _loger;

    [SetUp]
    public void Setup()
    {
        _loger = new Mock<ILogger<WeatherForecastController>>().Object;
        _controller = new WeatherForecastController(_loger);
    }

    [Test]
    public void Get_ReturnsOkResult()
    {
        //Arrange

        //Act
        var response = _controller.Get();

        //Assert
        Assert.That(response, Is.Not.Null);
        Assert.IsInstanceOf<OkObjectResult>(response);
    }
}