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
                else if (guessedAge > 31)
                    Console.WriteLine("Jeez, do you really think I look that old? >:(");
                else
                    Console.WriteLine("You're way too kind, but I\'m not that young.");

                Console.WriteLine($"Your current score: {totalScore}");

                bool fromSeattle = FromSeattle();
                if (fromSeattle == false)
                    totalScore++;
                Console.WriteLine($"Your current score: {totalScore}");

                StatesTraveled();
                Console.WriteLine($"Your current score: {totalScore}");

                CountriesTraveled();

                Console.WriteLine($"\nYour final score: {totalScore}");
                if (totalScore == 5)
                    Console.WriteLine("Oh snap! You're a boss!");

                Console.WriteLine("\nWould you like to play again?");
                string playAgainAns = Console.ReadLine();

                if (playAgainAns.ToUpper() == "Y" || playAgainAns.ToUpper() == "YES")
                {
                    playAgain = true;
                    totalScore = 0;
                }
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
                return "That's incorrect!";
        }

        public static int MyAge()
        {
            Console.WriteLine("\n2. How old do you think I am? Please enter an integer.");
            string ageGuess = Console.ReadLine();
            int ageGuessNum;
            bool isNumeric = int.TryParse(ageGuess, out ageGuessNum);
            while (isNumeric == false)
            {
                Console.WriteLine("That was not a valid integer. Please try again.");
                ageGuess = Console.ReadLine();
                isNumeric = int.TryParse(ageGuess, out ageGuessNum);
            }
            ageGuessNum = Int32.Parse(ageGuess);
            return ageGuessNum;
        }

        public static bool FromSeattle()
        {
            bool isTrueOrFalse = false;
            bool ansBool = true;

            do
            {
                Console.WriteLine("\n3. True/false: I'm from Seattle.");
                string fromSeattleAns = Console.ReadLine();
                if (fromSeattleAns.ToLower() == "false" || fromSeattleAns.ToLower() == "f")
                {
                    Console.WriteLine("That is correct! I'm from Anchorage, Alaska.");
                    ansBool = false;
                    isTrueOrFalse = true;
                }

                else if (fromSeattleAns.ToLower() == "true" || fromSeattleAns.ToLower() == "true")
                {
                    Console.WriteLine("That is incorrect! I'm not from here.");
                    ansBool = true;
                    isTrueOrFalse = true;
                }
    
                else
                {
                    Console.WriteLine("That was not a valid answer. Please try again.");
                }
            } while (isTrueOrFalse == false);

            return ansBool;
        }

        public static void StatesTraveled()
        {
            int guesses = 3;
            bool isCorrect = false;
            while (guesses > 0 && isCorrect == false)
            {
                Console.WriteLine("\n4. How many states do you think I've been to?");
                Console.WriteLine($"You have {guesses} guesses remaining.");
                string statesGuess = Console.ReadLine();
                int statesGuessNum;
                bool isNumeric = int.TryParse(statesGuess, out statesGuessNum);
                while (isNumeric == false)
                {
                    Console.WriteLine("That was not a valid integer. Please try again.");
                    statesGuess = Console.ReadLine();
                    isNumeric = int.TryParse(statesGuess, out statesGuessNum);
                }
                statesGuessNum = Int32.Parse(statesGuess);

                if (statesGuessNum == 9)
                {
                    Console.WriteLine("You're correct! I've been to 9 states.");
                    totalScore++;
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("That is incorrect!");
                    Console.WriteLine("Hint: I've been to less than 10 states.");
                    guesses--;
                }
            }
        }

        public static void CountriesTraveled()
        {
            int guessesLeft = 4;
            bool isCorrect = false;
            while (guessesLeft > 0 && isCorrect == false)
            {
                Console.WriteLine("\n4. How many countries do you think I've been to?");
                Console.WriteLine($"You have {guessesLeft} guesses remaining.");
                string countriesGuess = Console.ReadLine();
                int countriesGuessNum;
                bool isNumeric = int.TryParse(countriesGuess, out countriesGuessNum);
                while (isNumeric == false)
                {
                    Console.WriteLine("That was not a valid integer. Please try again.");
                    countriesGuess = Console.ReadLine();
                    isNumeric = int.TryParse(countriesGuess, out countriesGuessNum);
                }
                countriesGuessNum = Int32.Parse(countriesGuess);

                if (countriesGuessNum < 14)
                {
                    Console.WriteLine("Your guess is too low. I've been to more countries than that.");
                    Console.WriteLine("Please guess again.");
                    guessesLeft--;
                }
                else if (countriesGuessNum > 14)
                {
                    Console.WriteLine("Your guess is too high! I haven't traveled that much.");
                    Console.WriteLine("Please guess again.");
                    guessesLeft--;
                }
                else
                {
                    Console.WriteLine("You're correct! I've been to 14 countries.");
                    totalScore++;
                    isCorrect = true;
                }
            } 
        }
    }
}
