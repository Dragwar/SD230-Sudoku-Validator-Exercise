using System;
using System.Collections.Generic;

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
                throw new IndexOutOfRangeException($"Sudoku board's max row length is 9 (your number was: {rowNumber})");
            }
            else if (rowNumber < 0)
            {
                throw new IndexOutOfRangeException($"Sudoku board's min row length is 0 (your number was: {rowNumber})");
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
                throw new IndexOutOfRangeException($"Sudoku board's max column length is 9 (your number was: {columnNumber})");
            }
            else if (columnNumber < 0)
            {
                throw new IndexOutOfRangeException($"Sudoku board's min column length is 0 (your number was: {columnNumber})");
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



        // only testing displaying all values from the array
        public bool IsValidRows()
        {
            // first dimension (where the int[] arrays are stored)
            for (int i = 0; i < SudokuBoard.GetLength(0); i++)
            {
                // second dimension (where the int values are stored)
                for (int j = 0; j < SudokuBoard.GetLength(1); j++)
                {
                    // just printing all values right now
                    Console.WriteLine(SudokuBoard[i, j]);
                }
            }
            return false;
        }
    }
}
