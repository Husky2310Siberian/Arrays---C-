namespace ArrayCopyDemo;
/// <summary>
/// 
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int[] source = {1,2,3,4,5};
        int[] destination = new int[source.Length];
        int length = source.Length;
        
        Array.Copy(source, 1 , source , 0 , length-1);

        foreach (int el in source)
        {
            Console.Write(el + ", ");
        }
        Console.WriteLine("----");
        foreach (int el in destination)
        {
            Console.Write(el + ", ");
        }

    }
}