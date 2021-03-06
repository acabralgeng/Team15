﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Starfighter;

namespace Project_Starfighter_Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Background_Test
    {
        Background background; // create background

        public Background_Test()
        {
            background = new Background(); // initiate background
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        // test if the background offset value can be modified
        [TestMethod]
        public void BackgroundOffset_Test()
        {
            background.BackgroundOffset = 1;
            Assert.IsTrue(1 == background.BackgroundOffset);
        }

        // test if the background width can be modified to adjust to users preferences
        [TestMethod]
        public void BackgroundWidth_Test()
        {
            background.BackgroundWidth = 2;
            Assert.IsTrue(2 == background.BackgroundWidth);
        }

        // test if the background height can be modified to adjust to users preferences
        [TestMethod]
        public void BackgroundHeight_Test()
        {
            background.BackgroundHeight = 2;
            Assert.IsTrue(2 == background.BackgroundHeight);
        }
    }
}
