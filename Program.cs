using System;

namespace boulder_parchment_shears_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int computerScore = 0;
            Console.WriteLine("Hello console adventurer, would you like to play a game with me? (Y/N)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" || answer =="yes" ){
                Console.Clear();
                Console.WriteLine("I'm so excited! Let's play Boulder Parchment Shears :)");
                Console.WriteLine("Ready friend? (Y/N)");
                string ready = Console.ReadLine().ToLower();
                while(ready == "y" || ready =="yes"){
                    string[] computerOptions = { "boulder", "parchment", "shears" };
                    Random random = new Random();
                    int index = random.Next(0, computerOptions.Length);
                    Console.WriteLine("Make your choice: boulder, parchment, or shears!");
                    string playerChoice = Console.ReadLine().ToLower();
                    Console.Clear();
                    if (playerChoice == "boulder" || playerChoice == "parchment" || playerChoice == "shears"){
                        if (playerChoice == computerOptions[index])
                        {
                            Console.WriteLine($"You Chose {playerChoice} and I chose {computerOptions[index]}. It's a draw!");
                            Console.WriteLine($"Your Score: {playerScore}");
                            Console.WriteLine($"My Score: {computerScore}");
                            Console.WriteLine("Do you want to play again? (Y/N)");
                            ready = Console.ReadLine().ToLower();
                            Console.Clear();
                        }
                        else if (playerChoice == "boulder" && computerOptions[index] == "parchment")
                        {
                            computerScore++;
                            Console.WriteLine($"You Chose {playerChoice} and I chose {computerOptions[index]}. You lost! A point for me :)");
                            Console.WriteLine($"Your Score: {playerScore}");
                            Console.WriteLine($"My Score: {computerScore}");
                            Console.WriteLine("Do you want to play again? (Y/N)");
                            ready = Console.ReadLine().ToLower();
                            Console.Clear();
                        }
                        else if (playerChoice == "parchment" && computerOptions[index] == "shears")
                        {
                            computerScore++;
                            Console.WriteLine($"You Chose {playerChoice} and I chose {computerOptions[index]}. You lost! A point for me :)");
                            Console.WriteLine($"Your Score: {playerScore}");
                            Console.WriteLine($"My Score: {computerScore}");
                            Console.WriteLine("Do you want to play again? (Y/N)");
                            ready = Console.ReadLine().ToLower();
                            Console.Clear();
                        }
                        else if (playerChoice == "shears" && computerOptions[index] == "boulder")
                        {
                            computerScore++;
                            Console.WriteLine($"You Chose {playerChoice} and I chose {computerOptions[index]}. You lost! A point for me :)");
                            Console.WriteLine($"Your Score: {playerScore}");
                            Console.WriteLine($"My Score: {computerScore}");
                            Console.WriteLine("Do you want to play again? (Y/N)");
                            ready = Console.ReadLine().ToLower();
                            Console.Clear();
                        }
                        else
                        {
                            playerScore++;
                            Console.WriteLine($"You Chose {playerChoice} and I chose {computerOptions[index]}. You won! A point for you friend :)");
                            Console.WriteLine($"Your Score: {playerScore}");
                            Console.WriteLine($"My Score: {computerScore}");
                            Console.WriteLine("Do you want to play again? (Y/N)");
                            ready = Console.ReadLine().ToLower();
                            Console.Clear();
                        }
                    } else {
                    Console.WriteLine("No cheating!");
                    }
                }
            } else if(answer =="n" || answer =="no" ){
                Console.Clear();
                Console.WriteLine("Oh... maybe next time :(");
            }
            Console.WriteLine("See you later console adventurer!");
        }
    }
}
