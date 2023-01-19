using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhlSystemClassLibrary;

namespace NhlSystemTestProject
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        [DataRow(97, "Connor McDavid", Position.C)]
        [DataRow(93, "Ryan Nugent-Hopkins", Position.C)]
        [DataRow(91, "Evander Kane", Position.LW)]
        public void Constructor_ValidData_ShouldPass(int playerNo, string playerName, Position playerPosition)
        {
            //Arrange and Act
            Player currentPlayer = new Player(playerNo, playerName, playerPosition);
            //Assert
            Assert.AreEqual(playerNo, currentPlayer.PlayerNo);
            Assert.AreEqual(playerName, currentPlayer.Name);
            Assert.AreEqual(playerPosition, currentPlayer.Position);
        }

        [TestMethod]
        [DataRow(0, "Connor McDavid", Position.C)]
        [DataRow(99, "Connor McDavid", Position.C)]
        [DataRow(-1, "Connor McDavid", Position.C)]
        [DataRow(100, "Connor McDavid", Position.C)]
        public void PlayerNo_InvalidValue_ThrowsArgumentException(int playerNo, string playerName, Position playerPosition)
        {
            try
            {
                //Arrange and Act
                Player currentPlayer = new Player(playerNo, playerName, playerPosition);
                Assert.Fail("An argumentException should have been thrown");
            }
            catch(ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "PlayerNo Number must be between 1 and 98");
                //Assert.AreEqual(ex.Message, "PlayerNo Number must be between 1 and 98");
            }
            catch(Exception ex)
            {
                Assert.Fail("Incorrect exeption type thrown");
            }
        }

        [TestMethod]
        [DataRow(97, "", Position.C)]
        [DataRow(93, "      ", Position.C)]
        [DataRow(87, "Connor McDavid", Position.C)]
        [DataRow(43, null, Position.C)]
        public void Name_InvalidValue_ThrowsArgumentException(int playerNo, string playerName, Position playerPosition)
        {
            try
            {
                //Arrange and Act
                Player currentPlayer = new Player(playerNo, playerName, playerPosition);
                Assert.Fail("An argumentException should have been thrown");
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Name cannot be blank");
                Assert.AreEqual(ex.Message, "Name cannot be blank");
            }
            catch (Exception ex)
            {
                Assert.Fail("Incorrect exeption type thrown");
            }
        }

        //Write test methods for property validation for GamesPlayed, Goals, Assists, Points
        //Write test methods for methods AddGamesPlayed(), AddGoals(), AddAssists()

        [TestMethod]
        [DataRow()]
        [DataRow()]
        [DataRow()]
        [DataRow()]
        public void GamesPlayed_InvalidValue_ThrowsArgumentException(int playerNo, string playerName, Position playerPosition)
        {
            try
            {
                //Arrange and Act
                Player currentPlayer = new Player(playerNo, playerName, playerPosition);
                Assert.Fail("An argumentException should have been thrown");
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Games played must be greater than or equal to 0");
                Assert.AreEqual(ex.Message, "Games played must be greater than or equal to 0");
            }
            catch (Exception ex)
            {
                Assert.Fail("Incorrect exeption type thrown");
            }
        }

        [TestMethod]
        [DataRow()]
        [DataRow()]
        [DataRow()]
        [DataRow()]
        public void Goals_InvalidValue_ThrowsArgumentException(int playerNo, string playerName, Position playerPosition)
        {
            try
            {
                //Arrange and Act
                Player currentPlayer = new Player(playerNo, playerName, playerPosition);
                Assert.Fail("An argumentException should have been thrown");
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Goals must be greater than or equal to 0");
                Assert.AreEqual(ex.Message, "Goals must be greater than or equal to 0");
            }
            catch (Exception ex)
            {
                Assert.Fail("Incorrect exeption type thrown");
            }
        }

        [TestMethod]
        [DataRow()]
        [DataRow()]
        [DataRow()]
        [DataRow()]
        public void Assists_InvalidValue_ThrowsArgumentException(int playerNo, string playerName, Position playerPosition)
        {
            try
            {
                //Arrange and Act
                Player currentPlayer = new Player(playerNo, playerName, playerPosition);
                Assert.Fail("An argumentException should have been thrown");
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Assists must be greater than or equal to 0");
                Assert.AreEqual(ex.Message, "Assists must be greater than or equal to 0");
            }
            catch (Exception ex)
            {
                Assert.Fail("Incorrect exeption type thrown");
            }
        }

        [TestMethod]
        [DataRow()]
        [DataRow()]
        [DataRow()]
        [DataRow()]
        public void Points_InvalidValue_ThrowsArgumentException(int playerNo, string playerName, Position playerPosition)
        {
            try
            {
                //Arrange and Act
                Player currentPlayer = new Player(playerNo, playerName, playerPosition);
                Assert.Fail("An argumentException should have been thrown");
            }
            catch (ArgumentException ex)
            {
                //Dont need??
                StringAssert.Contains(ex.Message, "Games played must be greater than or equal to 0"); 
                Assert.AreEqual(ex.Message, "Games played must be greater than or equal to 0");
            }
            catch (Exception ex)
            {
                Assert.Fail("Incorrect exeption type thrown"); 
            }
        }
    }
}
