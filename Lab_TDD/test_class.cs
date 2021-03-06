﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Lab_TDD
{
    [TestClass]
    public class test_class
    {
        [TestMethod]
        public void TestNewGamer()
        {
            Gamer gamer = new Gamer();
            Assert.IsNotNull(gamer);
        }

        [TestMethod]
        public void TestName()
        {
            Gamer gamer = new Gamer();
            gamer.name = "test";
            Assert.AreEqual(gamer.name, "test");

        }

        


        [TestMethod]
        public void testplusrating()
        {
            Gamer gamer = new Gamer();
            gamer.rating = 0;
            gamer.PlusRating(10);
            Assert.AreEqual(gamer.rating, 10);
        }

        [TestMethod]
        public void testplusrating2()
        {
            Gamer gamer = new Gamer();
            gamer.rating = 0;
            gamer.PlusRating(20);
            Assert.AreEqual(gamer.rating, 20);
        }

        [TestMethod]
        public void testplusrating3()
        {
            Gamer gamer = new Gamer();
            gamer.rating = 0;
            gamer.PlusRating(30);
            Assert.AreEqual(gamer.rating, 30);
        }

        [TestMethod]
        public void TestNewMelody()
        {
            Melody melod = new Melody();
            Assert.IsNotNull(melod);
        }

        [TestMethod]
        public void TestMelodyNameFile()
        {
            Melody melod = new Melody();
            melod.name_file = "file.mp3";
            Assert.AreEqual(melod.name_file, "file.mp3");
        }

        [TestMethod]
        public void TestMelodyNameMelody()
        {
            Melody melod = new Melody();
            melod.name_melody = "Test";
            Assert.AreEqual(melod.name_melody, "Test");
        }

    }
}
