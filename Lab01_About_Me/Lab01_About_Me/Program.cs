using System;

namespace Lab01_About_Me
{
    class Program
    {
        public static short totalScore = 0;
        public static bool playAgain = false;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Hello, everyone! Welcome to the C# edition of my About Me Quiz!");
                Console.WriteLine("I'll give you 5 questions.");
                Console.WriteLine("Here we go!");

                Console.WriteLine(FavoriteColor());
                Console.WriteLine($"Your current score: {totalScore}");

                int guessedAge = MyAge();

                if (guessedAge == 31)
                {
                    Console.WriteLine("You're correct! I am 31 years old.");
                    totalScore++;
                }
                if (guessedAge > 31)
                    Console.WriteLine("Jeez, do you really think I look that old? >:(");
                if (guessedAge < 31)
                    Console.WriteLine("You're way too kind, but I\'m not that young.");

                Console.WriteLine($"Your current score: {totalScore}");

                bool fromSeattle = FromSeattle();
                if (fromSeattle == false)
                    totalScore++;
                Console.WriteLine($"Your current score: {totalScore}");

                Console.WriteLine("\nWould you like to play again?");
                string playAgainAns = Console.ReadLine();

                if (playAgainAns.ToUpper() == "Y" || playAgainAns.ToUpper() == "YES")
                    playAgain = true;
                else
                    playAgain = false;
            } while (playAgain == true);
            Console.WriteLine("\nThank you for playing. Please press any button to exit.");
            Console.ReadLine();
        }

        public static string FavoriteColor()
        {
            Console.WriteLine("\n1. What is my favorite color?");
            string colorGuess = Console.ReadLine();

            if (colorGuess.ToLower() == "blue")
            {
                totalScore++;
                return "That's correct!";
            }

            else
            {
                return "That's incorrect!";
            }
        }

        public static int MyAge()
        {
            Console.WriteLine("\n2. How old do you think I am? Please enter an integer.");
            string ageGuess = Console.ReadLine();
            int ageGuessNum;
            bool isNumeric = int.TryParse(ageGuess, out ageGuessNum);
            while (isNumeric == false)
            {
                Console.WriteLine("That was not a valid integer. Please guess my age again.");
                ageGuess = Console.ReadLine();
                isNumeric = int.TryParse(ageGuess, out ageGuessNum);
            }
            ageGuessNum = Int32.Parse(ageGuess);
            return ageGuessNum;
        }

        public static bool FromSeattle()
        {
            Console.WriteLine("\n3. True/false: I\'m from Seattle.");
            string fromSeattleAns = Console.ReadLine();
            bool ansBool;
            if (fromSeattleAns.ToLower() == "false" || fromSeattleAns.ToLower() == "f")
            {
                Console.WriteLine("That is correct! I'm from Anchorage, Alaska.");
                ansBool = false;
            }
            else
            {
                Console.WriteLine("That is incorrect! I\'m not from here.");
                ansBool = true;
            }
            return ansBool;
        }
    }
}
