using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuValidator
{
    public class SudokuBoardValidator
    {
        public int[,] SudokuBoard { get; private set; }

        public SudokuBoardValidator(int[,] sudokuBoard)
        {
            if (sudokuBoard.LongLength != 81)
            {
                throw new ArgumentException("SudokuBoardValidator can only take in a board that contains 81 elements");
            }
            SudokuBoard = sudokuBoard;
        }


        public int[] GetRow(int rowNumber)
        {
            if (rowNumber > 9)
            {
                throw new ArgumentOutOfRangeException($"Sudoku board's max row length is 9 (your number was: {rowNumber})");
            }
            else if (rowNumber < 0)
            {
                throw new ArgumentOutOfRangeException($"Sudoku board's min row length is 0 (your number was: {rowNumber})");
            }
            int[] row = new int[9];

            // first dimension (where the int[] arrays are stored)
            for (int i = 0; i < SudokuBoard.GetLength(0); i++)
            {
                // second dimension (where the int values are stored)
                for (int j = 0; j < SudokuBoard.GetLength(1); j++)
                {
                    if (i == rowNumber)
                    {
                        // think of j as all the elements in a row (while in this second nested loop)
                        row[j] = SudokuBoard[i, j];
                    }
                }
            }
            return row;
        }


        public int[] GetColumn(int columnNumber)
        {
            if (columnNumber > 9)
            {
                throw new ArgumentOutOfRangeException($"Sudoku board's max column length is 9 (your number was: {columnNumber})");
            }
            else if (columnNumber < 0)
            {
                throw new ArgumentOutOfRangeException($"Sudoku board's min column length is 0 (your number was: {columnNumber})");
            }
            int[] column = new int[9];

            // first dimension (where the int[] arrays are stored)
            for (int i = 0; i < SudokuBoard.GetLength(0); i++)
            {
                // second dimension (where the int values are stored)
                for (int j = 0; j < SudokuBoard.GetLength(1); j++)
                {
                    if (j == columnNumber)
                    {
                        // think of i like all the values in a column (while in this second nested loop)
                        column[i] = SudokuBoard[i, j];
                    }
                }
            }
            return column;
        }


        //public enum SquareXPosition
        //{
        //    Left = 0,
        //    Middle = 3,
        //    Right = 6,
        //}
        //public enum SquareYPosition
        //{
        //    Top = 3,
        //    Middle = 6,
        //    Bottom = 9,
        //}

        //public int[] GetSquare(SquareXPosition rowPosition = SquareXPosition.Right, SquareYPosition columnPosition = SquareYPosition.Middle)
        //{
        //    List<int> square = new List<int>();
        //    for (int i = 0; i < SudokuBoard.GetLength(0); i++)
        //    {
        //        int[] currentRow = GetRow(i).Skip((int)rowPosition).Take(3).ToArray();
        //        //int[] a = currentRow.Skip(1).Take(3).ToArray();
        //        square.AddRange(currentRow);
        //        //foreach (var item in a)
        //        //{
        //        //    Console.Write($"{item}, ");
        //        //}

        //    }

        //    switch (rowPosition)
        //    {
        //        case SquareXPosition.Middle:
        //            return square.Skip((int)rowPosition * 3).ToArray();
        //        case SquareXPosition.Right:
        //            return square.Skip((int)rowPosition * 3).ToArray();
        //        default:
        //            return square.ToArray();
        //    }

        //}
        //public void GetSquare()
        //{

        //    for (int i = 0; i < SudokuBoard.GetLength(0); i++)
        //    {
        //        List<int> square = new List<int>();

        //        int[] row = GetRow(i).Skip((int)SquareXPosition.Left).Take(3).ToArray();
        //        square.AddRange(row);

        //        for (int j = 0; j < 3; j++)
        //        {
        //            int[] col = GetColumn(j).Skip(1).Take(2).ToArray();
        //            square.AddRange(col);
        //        }


        //    }


        //}


        public bool IsValidRows()
        {
            for (int i = 0; i < SudokuBoard.GetLength(0); i++)
            {
                int[] currentRow = GetRow(i);
                foreach (int currentNumber in currentRow)
                {
                    // should always end up being 1 for each iteration
                    // unless duplicate was found
                    int numberOccurrenceCounter = 0;
                    foreach (int number in currentRow)
                    {
                        if (currentNumber == number)
                        {
                            // should always find one of the same number
                            // but if the counter goes above 1 then the row is invalid
                            numberOccurrenceCounter++;
                        }

                        if (numberOccurrenceCounter > 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }


        public bool IsValidColumns()
        {
            for (int i = 0; i < SudokuBoard.GetLength(1); i++)
            {
                int[] currentColumn = GetColumn(i);
                foreach (int currentNumber in currentColumn)
                {
                    // should always end up being 1 for each iteration
                    // unless duplicate was found
                    int numberOccurrenceCounter = 0;
                    foreach (int number in currentColumn)
                    {
                        if (currentNumber == number)
                        {
                            // should always find one of the same number
                            // but if the counter goes above 1 then the row is invalid
                            numberOccurrenceCounter++;
                        }

                        if (numberOccurrenceCounter > 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }


        public bool IsValidNumberValues()
        {
            foreach (int number in SudokuBoard)
            {
                if (number < 1 || number > 9)
                {
                    return false;
                }
            }
            return true;
        }


        public bool IsValidBoardSize()
        {
            if (SudokuBoard.GetLength(0) != 9)
            {
                return false;
            }
            if (SudokuBoard.GetLength(1) != 9)
            {
                return false;
            }
            return true;
        }


        [Obsolete("Not Implemented Yet", true)]
        public bool IsValidSqaures()
        {
            throw new NotImplementedException();
        }


        public bool IsValidBoard()
        {
            bool[] validators = new bool[]
            {
                IsValidBoardSize(),
                IsValidColumns(),
                IsValidNumberValues(),
                IsValidRows(),
                //IsValidSqaures(), // not implemented yet
            };
            foreach (bool boolean in validators)
            {
                if (!boolean)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
