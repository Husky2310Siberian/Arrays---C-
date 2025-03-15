namespace ArraysTwoDim;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        const int MAX = 6;
        const int MIN = 1;
        
        const int MAX_VALUE = 45;
        const int MIN_VALUE = 1;
        
        int[,] grid = new int[3, 4];
        
        int[,] grid2 = {
            { 1, 2, 3 }, { 4, 5, 6 } };

        // start traverse rows
        for (int row = 0; row < grid2.GetLength(0); row++)
        {
            // start traverse columns
            for (int column = 0; column < grid2.GetLength(1); column++)
            {
                Console.Write($"{grid2[row, column]} ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("------------");
        
        for (int row = 0; row < grid.GetLength(0) ; row++)
        {
            for (int column = 0; column < grid.GetLength(1); column++)
            {
                //giving random values in grid2 with class Random
                grid[row , column] = rnd.Next(MAX - MIN + 1) + MIN;
                Console.Write($"{grid[row, column]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("------------");
        /*
         * This code snippet in C# creates a jagged array,
         * which is essentially an array of arrays,
         * where each sub-array can have a different length.
         */
        int[][] jagged = new int[3][];
        jagged[0] = new int[3];
        jagged[1] = new int[4];
        jagged[2] = new int[5];

        for (int i = 0; i < jagged.GetLength(0); i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] = rnd.Next(MAX_VALUE - MIN_VALUE + 1) + MIN_VALUE;
                Console.Write($"{jagged[i][j]} ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("------------");
        
        foreach (int[] row in jagged)
        {
            foreach (int el in row)
            {
                Console.Write($"{el} ");    
            }
        }
    }
}