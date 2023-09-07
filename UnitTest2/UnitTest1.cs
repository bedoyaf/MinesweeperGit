using Minesweeper;
using NUnit.Framework;
//using NUnit.Extensions.Forms;
using System;
/*using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using Xunit;*/

namespace UnitTest2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void TestButton_Click()
        {
            Form1 form = new Form1(); // Create an instance of your Windows Form
            form.Show();
            ButtonTester buttonTester = new ButtonTester("myButton"); // Replace "myButton" with the actual name or text of your button
            form.tileGenerator.PerformClick(); // Replace YourButton with the actual button name

            // Assert: Verify the expected behavior (e.g., check label text, other controls)
            Assert.AreEqual("Button Clicked!", form.YourLabel.Text); // Replace YourLabel and the expected text
            form.Show(); // Show the form

            // Simulate a button click
            buttonTester.Click();

            // Perform assertions to verify the expected behavior
            Assert.AreEqual("Button Clicked!", form.LabelText);
        }
    }
}