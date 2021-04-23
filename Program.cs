using System;

using System.Threading.Tasks;

public class Program
{
    public static void Green(string word)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write(word);
        Console.ResetColor();
    }
    public static void Main()
    {
        const int repetitions = 1000;

        Task task1 = Task.Run(() =>
        {
            Green("1");
            for (int count = 0; count < repetitions; count++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
            }
        });
        Task task2 = Task.Run(() =>
        {
            Green("2");
            for (int count = 0; count < repetitions; count++)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
        });
        Task task3 = Task.Run(() =>
        {
            Green("3");
            for (int count = 0; count < repetitions; count++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
            }
        });




        Task task4 = Task.Run(() =>
        {
            Green("4");
            for (int count = 0; count < repetitions; count++)
            {
                Console.Write('+');
            }
        });
        Task task5 = Task.Run(() =>
        {
            Green("5");
            for (int count = 0; count < repetitions; count++)
            {
                Console.Write('-');
            }
        });
        


    task1.Wait();
    task2.Wait();
    task3.Wait();
    task4.Wait();
    task5.Wait();
    }
}