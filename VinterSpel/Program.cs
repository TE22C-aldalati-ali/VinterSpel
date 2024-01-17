using System;

class Aligame
{
    static void Main()
    {
        Console.WriteLine("Welcome to Aligame!");
        
        // Array of words for the game
        string[] words = { "programming", "developer", "csharp", "Aligame", "javascript", "webdeveloper","Micke","sverige," };

        // Choose a random word
        Random random = new Random();
        string selectedWord = words[random.Next(words.Length)];

        char[] guessedLetters = new char[selectedWord.Length];
        for (int i = 0; i < selectedWord.Length; i++)
        {
            guessedLetters[i] = '_';
        }

        int incorrectAttempts = 0;
        const int maxIncorrectAttempts = 6;

        while (incorrectAttempts < maxIncorrectAttempts)
        {
            // Display the current state of the word
            Console.WriteLine("Current word: " + new string(guessedLetters));
            
            // Prompt the user to guess a letter
            Console.Write("Enter a letter: ");
            char guess = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line

            // Check if the guessed letter is in the word
            bool correctGuess = false;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == guess)
                {
                    guessedLetters[i] = guess;
                    correctGuess = true;
                }
            }

            if (!correctGuess)
            {
                Console.WriteLine($"Incorrect! Attempts left: {maxIncorrectAttempts - incorrectAttempts - 1}");
                incorrectAttempts++;
            }

            // Check if the word has been guessed
            if (string.Join("", guessedLetters) == selectedWord)
            {
                Console.WriteLine("Congratulations! You guessed the word: " + selectedWord);
                break;
            }
        }

        if (incorrectAttempts == maxIncorrectAttempts)
        {
            Console.WriteLine("Sorry, you ran out of attempts. The correct word was: " + selectedWord);
        }
    }
}
