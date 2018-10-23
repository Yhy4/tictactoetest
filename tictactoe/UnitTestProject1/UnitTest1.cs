using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tictactoe;

namespace tictactoe.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void CurrentPlayerisXTest()
        {
            tictactoe tictactoe = new tictactoe();
            string currentplayer = tictactoe.CurrentPlayer(4);
            Assert.AreEqual("X", currentplayer);
        }
        [TestMethod()]
        public void CurrentPlayerisOTest()
        {
            tictactoe tictactoe = new tictactoe();
            string currentplayer = tictactoe.CurrentPlayer(1);
            Assert.AreEqual("O", currentplayer);
        }

        [TestMethod()]
        public void BoardIsNineField()
        {
            tictactoe tictactoe = new tictactoe();
            tictactoe.CreateBoard();
            Assert.AreEqual(9, tictactoe.TictactoeArray.Length);
        }
        [TestMethod()]
        public void CurrentPlayerPlaceX()
        {
            tictactoe tictactoe = new tictactoe();
            tictactoe.CreateBoard();
            tictactoe.MakeMove(2, "X");
            Assert.AreEqual("X", tictactoe.TictactoeArray[2]);
        }
        [TestMethod()]
        public void CurrentPlayerPlaceO()
        {
            tictactoe tictactoe = new tictactoe();
            tictactoe.CreateBoard();
            tictactoe.MakeMove(1, "O");
            Assert.AreEqual("O", tictactoe.TictactoeArray[1]);
        }
        [TestMethod()]
        public void placementIsUsed()
        {
            tictactoe tictactoe = new tictactoe();
            tictactoe.CreateBoard();
            bool inUsed= tictactoe.SpaceinUse(3);
            Assert.AreEqual(false, inUsed);
        }

    }
}

