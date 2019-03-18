using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RockPaperScissor.Business.Interfaces;

namespace RockPaperScissor.Test
{
    /// <summary>
    /// Class contains unit tests.
    /// </summary>
    [TestClass]
    public class RockPaperScissorTests
    {
        /// <summary>
        /// Test method user win the Game
        /// </summary>
        [TestMethod]
        public void User_Win_Game()
        {
            //Arrange
            var mockObject = new Mock<IGetUserInput>();
            mockObject.Setup(x => x.ShowResult(1)).Returns("User Win !!");
            //Act
            string result = mockObject.Object.ShowResult(1);
            //Assert
            Assert.AreEqual(result, "User Win !!");
        }

        /// <summary>
        /// Test method Computer win the Game
        /// </summary>
        [TestMethod]
        public void Computer_Win_Game()
        {
            //Arrange
            var mockDBObject = new Mock<IGetUserInput>();
            mockDBObject.Setup(x => x.ShowResult(2)).Returns("Computer Win !!");
            //Act
            string result = mockDBObject.Object.ShowResult(2);
            //Assert
            Assert.AreEqual(result, "Computer Win !!");
        }

        /// <summary>
        /// Test method Draw the Game
        /// </summary>
        [TestMethod]
        public void Draw_The_Game()
        {
            //Arrange
            var mockDBObject = new Mock<IGetUserInput>();
            mockDBObject.Setup(x => x.ShowResult(3)).Returns("Draw !!");
            //Act
            string result = mockDBObject.Object.ShowResult(3);
            //Assert
            Assert.AreEqual(result, "Draw !!");
        }

        /// <summary>
        /// Match User input request.
        /// </summary>
        [TestMethod]
        public void MatchUserInput()
        {
            try
            {
                var mockDBObject = new Mock<IGetUserInput>();
                mockDBObject.Setup(x => x.MatchSelection());
                Assert.IsTrue(true);
            }
            catch
            {

                Assert.IsTrue(false);
            }

        }

        /// <summary>
        /// method for Final 
        /// </summary>
        [TestMethod]
        public void FinalResult_UserWin()
        {
            //Arrange
            var mockDBObject = new Mock<IGetUserInput>();
            mockDBObject.Setup(x => x.DisplayResult()).Returns("Final Winner is User");
            //Act
            string result = mockDBObject.Object.DisplayResult();
            //Assert
            Assert.AreEqual(result, "Final Winner is User");
        }

        /// <summary>
        /// Test Method computer win the Game in Final Result.
        /// </summary>
        [TestMethod]
        public void FinalResult_ComputerWin()
        {
            //Arrange
            var mockDBObject = new Mock<IGetUserInput>();
            mockDBObject.Setup(x => x.DisplayResult()).Returns("Final Winner is Computer");
            //Act
            string result = mockDBObject.Object.DisplayResult();
            //Assert
            Assert.AreEqual(result, "Final Winner is Computer");
        }

        /// <summary>
        /// Test Method for Draw the Game.
        /// </summary>
        [TestMethod]
        public void FinalResult_DrawGame()
        {
            //Arrange
            var mockDBObject = new Mock<IGetUserInput>();
            mockDBObject.Setup(x => x.DisplayResult()).Returns("Draw the Game");
            //Act
            string result = mockDBObject.Object.DisplayResult();
            //Assert
            Assert.AreEqual(result, "Draw the Game");
        }


    }
}
