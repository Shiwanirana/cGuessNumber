using System;

namespace cGuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();
            Random random = new Random();
            int rNum = random.Next(1,101);
            bool won = false;
            while(!won)
            {
              Console.WriteLine("Guess a number between 1-100");
              // Console.Write(rNum);
              string num = Console.ReadLine();
              // Console.Clear();
              int number;
              if(Int32.TryParse(num, out number))
              {
               if(number == rNum)
                {
                 Console.Clear();
                 Console.WriteLine("you win");
                 won = true;
                }
                else if(number<rNum)
                 {
                  Console.Clear();
                  Console.WriteLine("Nope,guess higher");
               
                // won= false;
                 }
                else
                 {
                  Console.Clear();
                  Console.WriteLine("nope,guess lower");
                // won=true;
              }
            }
        }
        Console.WriteLine("Thanks!");
    }
}
}
