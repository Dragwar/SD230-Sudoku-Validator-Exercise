using SudokuValidator;
using Xunit;

namespace SudokuBoardXTest
{
    public class CheckIsValidBoard
    {
        [Fact]
        public void InvalidRow()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardRow);
            Assert.False(validator.IsValidRows());
        }

        [Fact]
        public void InvalidColumn()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardColumn);
            Assert.False(validator.IsValidColumns());
        }

        //[Fact]
        //public void InvalidSqaure()
        //{
        //    SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardSqaure);
        //    Assert.False(validator.IsValidSqaures());
        //}

        [Fact]
        public void InvalidNumbers()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardNumber);
            Assert.False(validator.IsValidNumberValues());
        }

        [Fact]
        public void InvalidColumnSize()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardColumnLength);
            Assert.False(validator.IsValidBoardSize());
        }

        [Fact]
        public void InvalidRowSize()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardRowLength);
            Assert.False(validator.IsValidBoardSize());
        }

        [Fact]
        public void ValidBoard()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.True(validator.IsValidBoard());
        }
    }
}
