using System;
namespace SudokuValidator
{
    public class Program
    {
        public static void Main()
        {
            SudokuValidator validator = new SudokuValidator(SudokuBoards.InvalidBoardColumnLength);

            Console.WriteLine("Sudoku Board:");
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


            Console.WriteLine("\n\nPress Any Key To Exit . . .");
            Console.ReadKey(false);
        }
    }
}
