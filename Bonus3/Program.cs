using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random ran = new Random();
                int ranNumber = ran.Next(1, 100);
                int index = 0;
                int[] guesses = new int[10];
                int guess = 0;
                Console.WriteLine("I'm going to pick a number 1 to 100 and you need to guess it in as few guesses as possible." +
                    "I'll give you ten guesses.");
                Console.WriteLine("Hmmmmm");
                Console.ReadKey();
                Console.WriteLine("Thinking....");
                Console.ReadKey();
                Console.Write("K got it.");
                
                while(GotAnswer(guess))
                {
                    if (index > 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You have {10 - index} guesses left.");
                        Console.WriteLine("\nMake a guess:");
                        //if the user input is in range, it logs it in the array and checks if it's high or low
                        if (IsInt1to100(Console.ReadLine()))
                        {
                            if(guess == ranNumber)
                            {
                                continue;
                            }
                            foreach (int g in guesses)
                            {
                                if (guess == g)
                                {
                                    Console.WriteLine("You've already guessed that. Better believe I'm still counting that.");
                                    index++;
                                    continue;
                                }
                            }

                            guesses[index] = guess;

                            if (guess > ranNumber)
                            {
                                if (guess > ranNumber + 40)
                                {
                                    Console.WriteLine("Your guess is high and waaaaaaay off");
                                }
                                else
                                {
                                    Console.WriteLine("Your guess is high");
                                }
                            }
                            else
                            {
                                if(guess < ranNumber - 40)
                                {
                                    Console.WriteLine("Your guess is low and out of the stadium");
                                }
                                else
                                {
                                    Console.WriteLine("Your guess is low.");
                                }
                            }
                            index++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Enter a whole number between 1 and 100. I'm counting that.");
                            index++;
                            continue;
                        }
                    }
                }

                string congrats;
                if(index == 10)
                {
                    congrats = "You made it by the skin of your teeth!";

                }
                else if (index > 8)
                {
                    congrats = "I didn't think you were going to make it but here we are.";
                }
                else if (index > 4)
                {
                    congrats = $"{index} guesses? Not too bad.";
                }
                else if (index >=1)
                {
                    congrats = $"{index} guesses? Dang you're good at this!";
                }
                else
                {
                    congrats = $"Got it on the first guess? I'd say you're amazing but it's more likely you're just lucky";
                }
                Console.WriteLine($"You got it!\n{congrats}");


                Console.WriteLine("Do you want to play again? (Y/N)");
                string uPlayAgain = Console.ReadLine()
                                           .ToUpper();
                if(uPlayAgain == "Y")
                {
                    continue;
                }

                bool GotAnswer(int num)
                {
                    if (num == ranNumber)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }


                //sees if it's a number 
                bool IsInt1to100(string num)
                {
                    if (int.TryParse(num, out guess))
                    {
                        if (guess >= 1 && guess <= 100)
                        {
                            return true;

                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                break;
            }

        }
    }
}
