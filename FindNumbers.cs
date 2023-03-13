using System;
public class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 7, 13, 19, 25, 31, 37, 43, 49, 55, 61, 67, 73, 79, 85, 91, 97, 100 };        
        Console.Write("Enter sum: ");
        int sum = int.Parse(Console.ReadLine());

        FindNumbers(numbers, sum);
      
    }

    public static void FindNumbers(List<int> numbers, int sum)
    {
        HashSet<int> complements = new HashSet<int>();
        foreach (int number in numbers)
        {
            if (complements.Contains(sum - number))
            {
                Console.WriteLine($"First pair found: ({sum-number}, {number})");
                return;
            }

            complements.Add(number);
        }

        Console.WriteLine("No pair found.");
    }
}