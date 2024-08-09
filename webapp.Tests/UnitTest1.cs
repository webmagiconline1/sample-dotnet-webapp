using Xunit;
using Microsoft.AspNetCore.Mvc;
using webapp.Controllers; // Adjust the namespace based on your project

namespace webapp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsAViewResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result); // Explicitly specify ViewResult as the type
        }
    }
}