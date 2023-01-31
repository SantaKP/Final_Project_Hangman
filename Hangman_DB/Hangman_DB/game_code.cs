using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_DB
{
     class game_code
    {

       
        public static void AnimalGuess() {
           
           string secretWord =  DB_analysis.DataBases();
            int lettersNmb = secretWord.Length;

            char[] guessarray = new char[lettersNmb];
        //Console.WriteLine("Please guess an animal that lives in: " + animallist[rnd].habitat);
        Console.WriteLine("Please enter your guess (only letters): ");

        for (int p = 0; p<lettersNmb; p++)
            guessarray[p] = '-';
        int mistakes = 0;


        while (mistakes< 9)
        {


            string playerGuessStr = Console.ReadLine();

        bool wordValidation = playerGuessStr.All(Char.IsLetter);



            if (wordValidation == false)
            {
                Console.WriteLine("Please enter only letters:");
                Console.WriteLine("Please try again:");

            }

    //bool onlyCharTest = playerGuessStr.All([0]);



    string playerGuessStrL = playerGuessStr.ToLower();
    Console.WriteLine("To Lower: " + playerGuessStrL);

            char playerGuess = char.Parse(playerGuessStrL);

    int positv = 0;
            for (int j = 0; j<lettersNmb; j++)
            {
                if (playerGuess == secretWord[j])
                {
                    guessarray[j] = playerGuess;
                    positv = positv + 1;

                }
            }
            if (positv == 0)
{
    Console.WriteLine(positv);
    mistakes = mistakes + 1;
    Console.WriteLine(" Your made " + mistakes + " mistakes");
    if (mistakes == 1)
    {
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|");
    }

    if (mistakes == 2)
    {
        Console.WriteLine("|             |");
        Console.WriteLine("|             |");
        Console.WriteLine("|             |");
        Console.WriteLine("|             |");
        Console.WriteLine("|             |");
        Console.WriteLine("|             |");
    }
    if (mistakes == 3)
    {
        Console.WriteLine("|-------------|");
        Console.WriteLine("|             |");
        Console.WriteLine("|             |");
        Console.WriteLine("|             |");
        Console.WriteLine("|             |");
        Console.WriteLine("|             |");
    }

    if (mistakes == 4)
    {
        Console.WriteLine("|------|-------|");
        Console.WriteLine("|      |       |");
        Console.WriteLine("|              |");
        Console.WriteLine("|              |");
        Console.WriteLine("|              |");
        Console.WriteLine("|              |");
    }
    if (mistakes == 5)
    {
        Console.WriteLine("|------|-------|");
        Console.WriteLine("|      |       |");
        Console.WriteLine("|      o       |");
        Console.WriteLine("|              |");
        Console.WriteLine("|              |");
        Console.WriteLine("|              |");
    }
    if (mistakes == 6)
    {
        Console.WriteLine("|------|-------|");
        Console.WriteLine("|      |       |");
        Console.WriteLine("|      o       |");
        Console.WriteLine("|      |       |");
        Console.WriteLine("|              |");
        Console.WriteLine("|              |");
    }
    if (mistakes == 7)
    {
        Console.WriteLine("|------|-------|");
        Console.WriteLine("|      |       |");
        Console.WriteLine("|      o       |");
        Console.WriteLine("|     -|       |");
        Console.WriteLine("|              |");
        Console.WriteLine("|              |");
    }
    if (mistakes == 8)
    {
        Console.WriteLine("|------|-------|");
        Console.WriteLine("|      |       |");
        Console.WriteLine("|      o       |");
        Console.WriteLine("|     -|-      |");
        Console.WriteLine("|              |");
        Console.WriteLine("|              |");
    }
    if (mistakes == 9)
    {
        Console.WriteLine("|------|-------|");
        Console.WriteLine("|      |       |");
        Console.WriteLine("|      o       |");
        Console.WriteLine("|     -|-      |");
        Console.WriteLine("|      L       |");
        Console.WriteLine("|              |");
    }
    if (mistakes == 9)
    {
        Console.WriteLine("|------|-------|");
        Console.WriteLine("|      |       |");
        Console.WriteLine("|      o       |");
        Console.WriteLine("|     -|-      |");
        Console.WriteLine("|      LL      |");
        Console.WriteLine("|              |");
    }
}

string strguess = string.Concat(guessarray);
Console.WriteLine(strguess);
if (strguess.Contains("-"))
{
    Console.WriteLine("There is still missing letters");
    if (mistakes == 3)
    {
        //Console.WriteLine("The animal " + animallist[rnd].hint);
    }
}
else
{
    Console.WriteLine("CONGRATULATIONS, YOU WON");
    break;
}



if (mistakes == 6)
{
    Console.WriteLine("YOU LOST");
    Console.WriteLine("The secret word was: " + secretWord);
}




        }
    }
}


//    static string ToChar(string? v)
//{
//    throw new NotImplementedException();
//}
    }




