using System;

public class Numberguess
{
    public void Main()
    {
        Random random = new Random();
        int RandNum = random.Next(1, 10);
        Console.WriteLine("Can you guess my number bewtween 1 and 10?");
        int Guess = 0;
        while (Guess != RandNum)
        {
            Guess = Convert.ToInt32(Console.ReadLine());
            if (Guess < RandNum)
            {Console.WriteLine ("Thats not my number, your guess was too low!");
            } else if (Guess > RandNum)
            {Console.WriteLine ("Thats not my number, your guess was too high!");
            } else {
            Console.WriteLine("Good Job, my number was " + RandNum + "!");
            Console.ReadLine();
            }
        }
    }
}
