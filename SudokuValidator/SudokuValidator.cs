using System;

namespace SudokuValidator
{
    public class SudokuValidator
    {
        public int[,] SudokuBoard { get; private set; }

        public SudokuValidator(int[,] sudokuBoard)
        {
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


    }
}
