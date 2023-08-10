using System;
using Microsoft.AspNetCore.Mvc;
using systemdesign;
using systemdesign.Controllers;

namespace xUnitTest;

public class WeatherForcastControlerTest
{
    [Fact]
    public void Get_CheckTypeIsWeatherForecastArray()
    {
        // Arrange
        var controller = new WeatherForecastController();

        // Act
        var result = controller.Get();

        // Assert
        Assert.IsType<WeatherForecast[]>(result);

    }
}