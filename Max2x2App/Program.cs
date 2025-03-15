using System.Data.Common;

namespace Max2x2App;

class Program
{
    static void Main(string[] args)
    {
        int sum;
        int maxSum = int.MinValue;
        int rowMax = 0;
        int colMax = 0;
        int[,] matrix =
        {
            {1, 2, 3, 4, 5, 6 },
            {2, 3, 4, 5, 6, 7 },
            {3, 4, 5, 6, 7, 8 },
            {4, 5, 6, 7, 8, 9 }
        };

        for (int row = 0; row < matrix.GetLength(0) -1 ; row++)
        {
            for (int column = 0; column < matrix.GetLength(1) - 1 ; column++)
            {
                sum = matrix[row, column] + matrix[row  , column + 1] + matrix[row + 1 , column] 
                      + matrix[row + 1 , column + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    rowMax = row;
                    colMax = column;
                }
            }
        }
        //Console.WriteLine(rowMax + "," + colMax);
        Console.WriteLine($"Max Sum = {maxSum} , RowMax = {rowMax}, ColMax = {colMax}" );
    }
}