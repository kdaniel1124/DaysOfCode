using DaysOfCode;
using System.Threading.Channels;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        DaysOfCode28 Testies = new DaysOfCode28();

        string[] fizzTest = Testies.FizzBuzz(15);

        foreach(string count in fizzTest)
        {
            Console.Write(count);
        }
    }
}