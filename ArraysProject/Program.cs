namespace ArraysProject;
/// <summary>
/// Different methods to create an array,
/// 
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        //1st , new
        int[] arr1 = new int[2];
        arr1[0] = 1;
        arr1[1] = 2;

        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write($"{arr1[i] + " "}");
        }
        Console.WriteLine();
        
        //2nd , unsized initialization
        int[] arr2 = { 1, 2, 3, 4, 5, 6 };

        foreach (int el in arr2)
        {
            Console.Write($"{el} ");
        }
        Console.WriteLine();
        
        //3rd , array initializer
        int[] arr3 = new int[] { 1, 2, 3, 4, 5, 6 };

        //4th , .NET8  --> Collection init
        int[] arr4 = [1, 2, 3, 4];
    }

    public static bool IsSymmetric(int[] arr)
    {
        bool symmetric = true;

        for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
        {
            if (arr[i] == arr[j])
                symmetric = false;
        }
        return symmetric; 
    }
}