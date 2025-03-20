namespace ArrayDemo;

class Program
{
    static void Main(string[] args)
    {
         int[] array = { 12, 2, 13, 444,-55, -6, 7 , 18, 49 };
         for (int i = 0; i < array.Length; i++)
        {
             Console.WriteLine("Element: {0} --> Value: {1}" , i , array[i]);
        }
        Console.WriteLine("------------------");
        int[][] jagged = new int[3][];
        jagged[0] = new int[5];
        jagged[1] = new int[15];
        jagged[2] = new int[20];

        for (int row = 0; row < jagged.Length ; row++)
        {
            for (int column = 0; column < jagged.Length; column++)
            {
                Console.WriteLine("Element : {0},{1} --> Value {2}" , row, column, jagged[row][column]);
            }
        }
        Console.WriteLine("------------------");
        int[][] jagged2 = new int[3][];
        jagged2[0] = new int[] {7,12,15};
        jagged2[1] = new int[] {-2,-8,99};
        jagged2[2] = new int[] {211,1233,544};

        for (int row = 0; row < jagged.Length; row++)
        {
            for (int column = 0; column < jagged.Length; column++)
            {
                Console.WriteLine("Element : {0},{1} --> Value {2}" , row , column , jagged2[row][column]);
            }
        }
        Console.WriteLine("------------------");
        
        int[][] jagged3 = new int[3][];
        jagged3[0] = new int[4] {7, 12, 15, 22 };
        jagged3[1] = new int[5] {2, 8, 99, 55, 66 };
        jagged3[2] = new int[6] {-211, -1233, -544, 888, 567, 345 };

        foreach (int[] row in jagged3)
        {
            foreach (int i in row)
            {
                Console.Write(i +  ", ");
            }
            Console.WriteLine();
        }
    }
}