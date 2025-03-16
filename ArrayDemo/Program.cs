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
    }
}