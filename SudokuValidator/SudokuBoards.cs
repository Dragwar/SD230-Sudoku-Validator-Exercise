using System;

namespace SudokuValidator
{
    public static class SudokuBoards
    {
        // Note:
        // this syntax uses a getter in the background
        // public static int[,] ValidBoard => new int[,] { . . . }
        //                                  ^
        //
        // syntax above does the same as this syntax below:
        // public static int[,] ValidBoard { get => new int[,] { . . . } }

        public static int[,] ValidBoard => new int[,]
        {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 1, 9, 5, 3, 4, 8},
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9},
        };
        public static int[,] InvalidBoardRow => new int[,]
        {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 9, 9, 5, 3, 4, 8},// invalid two number 9s
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 0, 2, 4, 8, 5, 6},// invalid number 0
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9},
        };
        public static int[,] InvalidBoardColumn => new int[,]
        {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},// invalid duplicate number 7 (below)
            {6, 9, 2, 1, 7, 5, 3, 4, 8},// invalid duplicate number 7, 9 (above, below)
            {1, 9, 8, 3, 4, 2, 5, 6, 7},// invalid duplicate number 9 (above)
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9},
        };
        public static int[,] InvalidBoardSqaure => new int[,]
        {
            // all 3x3 squares are invalid
            {1, 2, 3, 4, 5, 6, 7, 8, 9},
            {2, 3, 4, 5, 6, 7, 8, 9, 1},
            {3, 4, 5, 6, 7, 8, 9, 1, 2},
            {4, 5, 6, 7, 8, 9, 1, 2, 3},
            {5, 6, 7, 8, 9, 1, 2, 3, 4},
            {6, 7, 8, 9, 1, 2, 3, 4, 5},
            {7, 8, 9, 1, 2, 3, 4, 5, 6},
            {8, 9, 1, 2, 3, 4, 5, 6, 7},
            {9, 1, 2, 3, 4, 5, 6, 7, 8},
        };
        public static int[,] InvalidBoardNumber => new int[,]
        {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 1, 9, 5, 3, 4, 8},
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 500, 3, 7, 9, 1},// only numbers between 1 to 9
            {7, 1, 3, 9, -200, 4, 8, 5, 6},// only numbers between 1 to 9
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9},
        };
        public static int[,] InvalidBoardColumnLength => new int[,]
        {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 1, 9, 5, 3, 4, 8},
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9},
            
            // extra column
            {4, 2, 6, 8, 5, 3, 7, 9, 1}// column length can only be 9
        };
        public static int[,] InvalidBoardRowLength => new int[9, 10]
        {
            {5, 3, 4, 6, 7, 8, 9, 1, 2, 1}, // row length should be 9 and numbers don't work
            {6, 7, 2, 1, 9, 5, 3, 4, 8, 2}, // row length should be 9 and numbers don't work
            {1, 9, 8, 3, 4, 2, 5, 6, 7, 3}, // row length should be 9 and numbers don't work
            {8, 5, 9, 7, 6, 1, 4, 2, 3, 4}, // row length should be 9 and numbers don't work
            {4, 2, 6, 8, 5, 3, 7, 9, 1, 1}, // row length should be 9 and numbers don't work
            {7, 1, 3, 9, 2, 4, 8, 5, 6, 7}, // row length should be 9 and numbers don't work
            {9, 6, 1, 5, 3, 7, 2, 8, 4, 8}, // row length should be 9 and numbers don't work
            {2, 8, 7, 4, 1, 9, 6, 3, 5, 9}, // row length should be 9 and numbers don't work
            {3, 4, 5, 2, 8, 6, 1, 7, 9, 10},// row length should be 9 and numbers don't work
        };

        public static void PrintInOneLine(this int[] array)
        {
            foreach (int number in array)
            {
                if (number == array[array.Length - 1])
                {
                    Console.Write(number);
                }
                else
                {
                    Console.Write(number + ", ");
                }
            }
        }
    }
}
