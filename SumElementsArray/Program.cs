namespace SumElementsArray;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int sub = 0;
        int[] array = new int [5];
        int[] array2 = new int [5];
        Console.WriteLine("Enter the number of elements in the array:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Element {0} , Value {1}", array[i], i );
        }
        Console.WriteLine("The sum of the elements in the array is: {0}", sum);
        
        Console.WriteLine("----------------------------------");
        
        Console.WriteLine("Enter the number of elements in the array:");
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
            sub -= array2[i];
        }

        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine("Element {0} , Value {1}", array2[i], i);
        }
        Console.WriteLine("The sub of the elements in the array is: {0}", sub);
    }
}