using System;
namespace SudokuValidator
{
    public class Program
    {
        public static void Main()
        {
            SudokuBoardValidator validator = new SudokuBoardValidator(SudokuBoards.ValidBoard);

            Console.WriteLine($"Sudoku Board ({nameof(SudokuBoards.ValidBoard)}):");
            for (int i = 0; i < validator.SudokuBoard.GetLength(0); i++)
            {
                Console.WriteLine();
                validator.GetRow(i).PrintInOneLine();
            }

            Console.WriteLine("\n\nHas A Valid Board Size?");
            Console.WriteLine(validator.IsValidBoardSize());

            Console.WriteLine("\n\nHas Valid Number Values?");
            Console.WriteLine(validator.IsValidNumberValues());

            Console.WriteLine("\n\nHas Valid Rows?");
            Console.WriteLine(validator.IsValidRows());

            Console.WriteLine("\n\nHas Valid Columns?");
            Console.WriteLine(validator.IsValidColumns());

            //Console.WriteLine("\n\nHas Valid Squares?");
            //Console.WriteLine(validator.IsValidSqaures());


            Console.WriteLine("\n\nPress Any Key To Exit . . .");
            Console.ReadKey(false);
        }
    }
}
