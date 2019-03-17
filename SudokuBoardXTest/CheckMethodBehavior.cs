using SudokuValidator;
using System;
using Xunit;

namespace SudokuBoardXTest
{
    public class CheckMethodBehavior
    {
        #region GetRowInvalidRange Tests
        [Fact]
        public void GetRowInvalidRange_1()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.Throws<ArgumentOutOfRangeException>(() => validator.GetRow(-1));
        }

        [Fact]
        public void GetRowInvalidRange_2()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.Throws<ArgumentOutOfRangeException>(() => validator.GetRow(43));
        }
        #endregion

        #region GetColumnInvalidRange Tests
        [Fact]
        public void GetColumnInvalidRange_1()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.Throws<ArgumentOutOfRangeException>(() => validator.GetColumn(-1));
        }
        [Fact]
        public void GetColumnInvalidRange_2()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.Throws<ArgumentOutOfRangeException>(() => validator.GetColumn(35));
        }
        #endregion


    }
}
