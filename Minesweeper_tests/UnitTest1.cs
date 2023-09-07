using Minesweeper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Minesweeper.Form1;
using System.Drawing;
using System.Reflection;
using System.Windows;
using System.Windows.Forms;

namespace Minesweeper_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFlagPlacing()
        {
            Form1 form = new Form1(); // Create an instance of your Windows Form
            //form.Show();
            Tile newtile = new Tile();
            //newbutton.Setflag();
            bool expected = true;
           // newbutton.PlaceFlag(1,0);
            PlaceFlag(newbutton);
           // Minesweeper.Form1.PlaceFlag(newbutton);
            Assert.AreEqual(expected, newtile.Getflag(), "Account not debited correctly");
        }

    }
}