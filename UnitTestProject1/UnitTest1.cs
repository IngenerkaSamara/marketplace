using FormsAppEvoX;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Game game1 = new Game { name = "Game 1", price = 20 };
            Form1.games_list = new List<Game> { game1 };

            GameForm gf = new GameForm(game1.name);

            Assert.AreEqual(game1.name, gf.game1.name);
            Assert.AreEqual(game1.price, gf.game1.price);
        }
    }
}
