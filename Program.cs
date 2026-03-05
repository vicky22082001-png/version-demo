using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("CI/CD Version Demo");

        Console.WriteLine($"Machine: {Environment.MachineName}");
        Console.WriteLine($"Time: {DateTime.Now}");

        Console.WriteLine("Application version: v1.0.0");
    }
}