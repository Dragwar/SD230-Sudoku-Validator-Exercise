using SudokuValidator;
using System;
using Xunit;

namespace SudokuBoardXTest
{
    public class CheckMethodBehavior
    {
        [Fact]
        public void GetRowInvalidRange()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.Throws<ArgumentOutOfRangeException>(() => validator.GetRow(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => validator.GetRow(43));
        }

        [Fact]
        public void GetColumnInvalidRange()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.Throws<ArgumentOutOfRangeException>(() => validator.GetColumn(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => validator.GetColumn(35));
        }


    }
}
