using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide an argument to specify which part to run (1, 2, or 3).");
            return;
        }

        string partToRun = args[0];

        switch (partToRun)
        {
            case "1":
                Part1();
                break;

            case "2":
                Part2();
                break;

            case "3":
                Part3();
                break;
            
            case "4":
                Part4();
                break;

            case "5":
                Part5();
                break;
            
            case "6":
                Part6();
                break;
            case "7":
                Part7();
                break;

            default:
                Console.WriteLine("Invalid argument. Please use 1, 2, or 3.");
                break;
        }
    }

    static void Part1()
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}");
        Console.WriteLine($"{Environment.NewLine}It's a beautiful day!");
        Console.WriteLine($"{Environment.NewLine}What's your mood today?");
        var mood = Console.ReadLine();
        Console.WriteLine($"{Environment.NewLine}I can imagine you're feeling {mood}");
        Console.WriteLine($"{Environment.NewLine}What activity would you like to do today?");
        var activity = Console.ReadLine();
        Console.WriteLine($"{Environment.NewLine}Well, {activity} sure sounds great!");
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
    }

    static void Part2()
    {
        Console.WriteLine($"{Environment.NewLine}Let's start a new C sharp learning activity");

        string firstFriend = "     Meg";
        firstFriend = firstFriend.Trim();

        string secondFriend = "Katie";

        string friends = $"My friends are {firstFriend} and {secondFriend}";

        Console.WriteLine(friends);
    }

    static void Part3()
    {
        Console.WriteLine($"{Environment.NewLine}Welcome to Part 3 - Integer Exercises");

        int a = 210000000;
        int b = 210000000;
        long c =(long)a + b;
        Console.WriteLine(c);
       
    }

    static void Part4()
    {
        int counter = 0;
        do 
        {
            Console.WriteLine(counter);
            counter++;
        }

        while (counter < 5);
    }

    
    static void Part5()
    {
      
       for (int i = 0; i < 5; i++)
       {
        Console.WriteLine(i);
       }
    }

    static void Part6()
    {
      var names = new List <string> {"Tara","Scott","Bob"};

      foreach(var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
       
    }

    static void Part7()
    {
      List <int> scores = [5,6,8,2,3,4,5];
    
    //This is a query expression
      IEnumerable <string> scoreQuery = //query variable
      from score in scores //required 
      where score > 5 //optional
      orderby score descending //optional
      select $"The score is {score}"; //must end with select or group

      foreach (string s in scoreQuery) 
      {
        Console.WriteLine(s);

      }
       
    }
}

