namespace ArrayMaxMinPosition;
/// <summary>
/// Finds the min and max element of an array
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int [] ages = { 10, 20, 3, 4,  10 , 18 , 25 , 29 , 4 };
        int minPosition = 0;
        int maxPosition = 0;

        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[maxPosition] < ages[i])
            {
                maxPosition = i;
            }
        }
        Console.WriteLine("Max Element {0}  in position {1}", ages[maxPosition] , maxPosition + 1);
        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[minPosition] > ages[i])
            {
                minPosition = i;
            }
        }
        Console.WriteLine("Min Element {0}  in position {1}", ages[minPosition] , minPosition + 1);
    }
}