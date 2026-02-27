using System;
using System.Threading.Tasks.Sources;

namespace While_Loop_Programming_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
        }
        public static void Part1()
        {
            //Simple casino game
            Random gen= new Random();

            int score, num;
            
            bool done = false;
            score = 3;
            string guess, answer;
            Console.WriteLine("Hello, and welcome to my simple casino game!");
            Console.WriteLine("The rules are simple. You have " + score + " points if you run out of points it's GAME OVER!");
            Console.WriteLine("You will Guess either heads or tails. If your wrong you lose a point and if your right you win a point.");
            Console.WriteLine("Okay let's get this show on the road");
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();
            Console.Clear();

            while (!done)
            {
               
                num = gen.Next(1, 3);
                Console.WriteLine(num);
                Console.WriteLine("Heads or Tails");
                guess= Console.ReadLine().ToLower();
                if (guess == "heads" && num == 1 || guess == "head" && num == 1)
                {
                    Console.WriteLine("It was Heads! You got it right!!!");
                    score++;
                    Console.WriteLine("Your score is " + score + " nice job.");
                }
                if (guess == "tails" && num ==2 || guess == "tail" && num == 2)
                {
                    Console.WriteLine("It was Tails! You got it right!!!");
                    score++;
                    Console.WriteLine("Your score is " + score + " nice job.");
                }
                if (guess == "heads" && num ==2 || guess == "head" && num == 2)
                {
                    Console.WriteLine("It was Tails! You got it wrong. :(");
                    score--;
                    Console.WriteLine("Your score is " + score + ". Better luck next time.");
                }
                if (guess == "tails" && num == 1 || guess == "tail" && num == 1)
                {
                    Console.WriteLine("It was Heads! You got it wrong. :(");
                    score--;
                    Console.WriteLine("Your score is " + score + ". Better luck next time.");
                }
                 if (score == 0)
                {
                    done = true;
                    Console.WriteLine("You lose");
                    Console.WriteLine("You have " + score + " points remaining");
                }
                
                Console.WriteLine("Would you like to keep playing. Yes or No.");
                answer = Console.ReadLine().ToLower();
                if (answer == "no")
                {
                   Console.WriteLine("Okay. Thanks for Playing!");
                    Console.WriteLine("Your final score was " + score + " points.");
                    Console.WriteLine("PLEASE VISIT MR.ALDWORTH FOR A REAL LIFE CONVERSION RATE OF 1-100cad");
                    done = true;

                }
               
            }






        }
    }
}
