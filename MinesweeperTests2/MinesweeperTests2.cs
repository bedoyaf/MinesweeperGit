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