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

        // only testing displaying all values from the array
        public bool CheckValidRows()
        {
            // first dimension (where the int[] arrays are stored)
            for (int i = 0; i < SudokuBoard.GetLength(0); i++)
            {
                // second dimension (where the int values are stored)
                for (int j = 0; j < SudokuBoard.GetLength(1); j++)
                {
                    Console.WriteLine(SudokuBoard[i, j]);
                }
            }
            return false;
        }
    }
}
