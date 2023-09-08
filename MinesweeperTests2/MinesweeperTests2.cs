//using Minesweeper;
//using static Minesweeper.Form1;
using System.Drawing;
using System.Reflection;
using System.Windows;
using Xunit;
using ClassLibraryMineSweeper;
namespace MinesweeperTests2
{
    public class MinesweeperTests2
    {
        [Fact]
        public void YourTestMethod()
        {
            // Arrange: Prepare your test data and objects
            int expected = 42;
            int actual = 42;

            // Act: Execute the method to be tested

            // Assert: Verify the expected results
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CheckAppHeight()
        {
            int calculated = ClassLibraryMineSweeper.Functions.AppHeight(8);
            int expected = 580;
            Assert.Equal(expected, calculated);

        }
        [Fact]
        public void CheckAppWidth()
        {
            int calculated = ClassLibraryMineSweeper.Functions.AppWidth(8);
            int expected = 849;
            Assert.Equal(expected, calculated);
        }
        [Fact]
        public void CheckButtonLocationj()
        {
            int calculated = ClassLibraryMineSweeper.Functions.ButtonLocationj(8);
            int expected = 270;
            Assert.Equal(expected, calculated);
        }
        [Fact]
        public void CheckButtonLocationi()
        {
            int calculated = ClassLibraryMineSweeper.Functions.ButtonLocationi(8);
            int expected = 270;
            Assert.Equal(expected, calculated);
        }

    }
}