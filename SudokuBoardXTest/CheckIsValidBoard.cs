using SudokuValidator;
using System;
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

            validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.True(validator.IsValidRows());
        }

        [Fact]
        public void InvalidColumn()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardColumn);
            Assert.False(validator.IsValidColumns());

            validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.True(validator.IsValidRows());
        }

        //[Fact]
        //public void InvalidSqaure()
        //{
        //    SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardSqaure);
        //    Assert.False(validator.IsValidSqaures());
        //
        //    validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
        //    Assert.True(validator.IsValidSqaures());
        //}

        [Fact]
        public void InvalidNumbers()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardNumber);
            Assert.False(validator.IsValidNumberValues());

            validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.True(validator.IsValidNumberValues());
        }

        [Fact]
        public void InvalidColumnSize()
        {
            Assert.Throws<ArgumentException>(() => new SudokuBoardValidator(SudokuBoards.InvalidBoardColumnLength));

            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardColumn);
            Assert.True(validator.IsValidBoardSize());

            validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.True(validator.IsValidBoardSize());
        }

        [Fact]
        public void InvalidRowSize()
        {
            Assert.Throws<ArgumentException>(() => new SudokuBoardValidator(SudokuBoards.InvalidBoardRowLength));

            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.InvalidBoardRow);
            Assert.True(validator.IsValidBoardSize());

            validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.True(validator.IsValidBoardSize());
        }

        [Fact]
        public void ValidBoard()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);
            Assert.True(validator.IsValidBoard());
        }
    }
}
