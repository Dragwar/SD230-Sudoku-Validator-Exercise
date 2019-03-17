using System;
namespace SudokuValidator
{
    public class Program
    {
        public static void Main()
        {
            SudokuValidator validator = new SudokuValidator(SudokuBoards.ValidBoard);
            //validator.CheckValidRows();

            // print first row
            validator.GetRow(0).PrintInOneLine("First Row:");

            // print first column
            validator.GetColumn(0).PrintInOneLine("First Column:");



            Console.WriteLine("\n\nPress Any Key To Exit . . .");
            Console.ReadKey(false);
        }
    }
}
