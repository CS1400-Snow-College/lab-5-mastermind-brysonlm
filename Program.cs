// Bryson LeonM 2/13/26

string secret = "afdb";
int guessCount = 0;

Console.WriteLine("I have chosen 4 letters between 'a' and 'g' and have arranged them in a particular order.");
Console.WriteLine("Your job is to guess the letters and put them in the right order.");
Console.WriteLine();

string guess;

// keep looping until the correct
do
{
    guessCount++;
    Console.WriteLine("Guess #" + guessCount + ": Please guess a sequence of 4 lowercase letters with no repeats.");
    guess = Console.ReadLine();

    if (guess == secret)
    {
        break;
    }

    // stores the guess results
    int correctPositions = 0;
    int wrongPositions = 0;

    // loops throught he secret and comparing it to the guess
    for (int i = 0; i < secret.Length; i++)
    {
        if (guess[i] == secret[i])
        {
            correctPositions++;
        }
        else
        {
            // scan the secret to see if it appears anywhere
            for (int j = 0; j < secret.Length; j++)
            {
                if (guess[i] == secret[j])
                {
                    wrongPositions++;
                    // stop when we find a match to not count it twice
                    break;
                }
            }
        }
    }

    Console.WriteLine("  - " + correctPositions + " in the right positions");
    Console.WriteLine("  - " + wrongPositions + " in the wrong positions");
    Console.WriteLine();

} while (guess != secret);

Console.WriteLine("You did it! You guessed my secret (" + secret + ") in " + guessCount + " guesses.");