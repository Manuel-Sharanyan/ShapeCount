using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace Homework.Tests
{
    public class ProgramTests
    {
        [Test]
        public void CalculateArea_ValidInput_ReturnsCorrectArea()
        {
            // Arrange
            int height = 5;
            int width = 3;

            // Act
            int result = CalculateArea(height, width);

            // Assert
            //Assert.AreEqual(15, result);
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void CalculatePerimeter_ValidInput_ReturnsCorrectPerimeter()
        {
            // Arrange
            int height = 5;
            int width = 3;

            // Act
            int result = CalculatePerimeter(height, width);

            // Assert
            //Assert.AreEqual(16, result);
            Assert.That(result, Is.EqualTo(16));
        }

        [Test]
        public void CalculateDraw_ValidInput_ReturnsCorrectDraw()
        {
            // Arrange
            int height = 5;
            int width = 3;

            // Act
            int result = CalculateDraw(height, width);

            // Assert
            //Assert.AreEqual(2, result);
            Assert.That(result, Is.EqualTo(2));
        }


        private int CalculateArea(int height, int width)
        {
            return height * width;
        }

        private int CalculatePerimeter(int height, int width)
        {
            return 2 * (height + width);
        }

        private int CalculateDraw(int height, int width)
        {
            return height - width;
        }

    }
}
