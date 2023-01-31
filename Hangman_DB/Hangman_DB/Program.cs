using Hangman_DB;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class HangmanDB
{

    static void Main(string[] args)
    {
       
        char Ainput = InputVal.input();

        game_code.AnimalGuess();



    }


}





    class InputVal { 

    public static char input () {  
    {


            Console.WriteLine("Please choose what to guess! Enter V - for vegetables; A - for animals and F - for fruit:");

            char input = char.Parse(Console.ReadLine());
    input = char.ToUpper(input);
        
        if (input != 'A' && input != 'F' && input != 'V')
        {

            Console.WriteLine("Wrong input. Please try again:");
            input = char.Parse(Console.ReadLine());
        }
        else { Console.WriteLine("Please start guessing:"); }

        return input;
    }
       

}


}






