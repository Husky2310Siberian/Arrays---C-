namespace ArraysTwoDim;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        const int MAX = 6;
        const int MIN = 1;
        
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
    }
}