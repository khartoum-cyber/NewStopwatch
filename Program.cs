using System;

namespace NewStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type 'start' to start stopwatch.");
            Console.WriteLine("Please type 'stop' to stop stopwatch.");
            Console.WriteLine("Please type 'exit' to exit.");


            string command = "";

            do
            {
                try
                {
                    command = Console.ReadLine().ToLower();

                    if (command == "start")
                    {
                        Console.Clear();
                        Stopwatch.Start();
                        Console.WriteLine("Stopwatch running...\nType 'stop' to calculate the time or 'exit' to leave.");
                    }
                    else if (command == "stop")
                    {
                        Console.Clear();
                        var elapsedTime = Stopwatch.Stop();
                        Console.WriteLine($"Elapsed time = {elapsedTime}");
                        Console.WriteLine("Type 'start' to start new stopwatch or 'exit' to leave.");
                    }
                    else if (command == "exit")
                    {
                        Console.WriteLine("Thank you for using my stopwatch program!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input!\n");
                        Console.WriteLine("Please type 'start' to start stopwatch.");
                        Console.WriteLine("Please type 'stop' to stop stopwatch.");
                        Console.WriteLine("Please type 'exit' to exit.");
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error details: {0}", ex.Message);
                }

            } while (command != "exit");
        }
    }
}
