﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Starfighter;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project_Starfighter_Test
{
    [TestClass]
    public class Enemy2_Test
    {
        static Texture2D texture = null;

        static int X = 0;
        static int Y = 0;
        static int W = 45;
        static int H = 73;
        static int Frames = 1;

        Enemy2 target = new Enemy2(texture, X, Y, W, H, Frames); // create a new enemy

        // test if enemy can be deactivated
        [TestMethod]
        public void Deactivate_Test()
        {
            target.Deactivate();
            Assert.IsFalse(target.IsActive);
        }

        // test if enemy is initially set to inactive
        [TestMethod]
        public void IsActive_Test()
        {
            Assert.AreEqual(false, target.IsActive);
        }

        // test if boss's x position can be changed
        [TestMethod]
        public void X_Test()
        {
            int xtest = 45;
            target.X = xtest;
            Assert.AreEqual(xtest, target.X);
        }

        // test if boss's y position can be changed
        [TestMethod]
        public void Y_Test()
        {
            int ytest = 45;
            target.Y = ytest;
            Assert.AreEqual(ytest, target.Y);
        }

        // test if the enemy will be activated in the correct position
        [TestMethod]
        public void Generate_Test()
        {
            target.Generate(1);
            Assert.AreEqual(750, target.X);
            Assert.AreEqual(150, target.Y);
            Assert.IsTrue(target.IsActive);
        }

        // check if the method that changes the enemy's direction in case it is out of the limits is working
        [TestMethod]
        public void GetDrawY_Test()
        {
            target.Generate(1);
            target.Y = 201;
            target.GetDrawY();
            Assert.IsTrue(target.getChangeDirection);

            target.Y = 99;
            target.GetDrawY();
            Assert.IsFalse(target.getChangeDirection);

        }

        // test if the bounding box is the desired size of the enemy's current image
        [TestMethod]
        public void BoundingBox_Test()
        {
            Rectangle square = new Rectangle(752, 77, 42, 71);

            target.Generate(0);
            Assert.AreEqual(square, target.CollisionBox);

        }

    }
}
