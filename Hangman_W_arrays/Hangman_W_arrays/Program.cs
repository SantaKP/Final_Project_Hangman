class HangmanMain
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Please enter word to guess: ");
        string guesingWord = Console.ReadLine();

        bool wordValidation = guesingWord.All(Char.IsLetter);
        guesingWord = guesingWord.ToUpper();


        while (wordValidation == false || guesingWord.Length == 0)


        {
            Console.WriteLine("Please enter only letters! Try again:");
            guesingWord = Console.ReadLine();
            wordValidation = guesingWord.All(Char.IsLetter);



        }

        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" +
                                "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" +
                                "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        char input;
        int lives = 10;
        int WordLenght = guesingWord.Length;
        char[] arrayWord = guesingWord.ToCharArray();
        char[] guessInput = new char[WordLenght];
        Console.WriteLine("Word you must guess has " + WordLenght + " " + "letters.");

        Console.WriteLine("Please guess first letter: ");


        input = Convert.ToChar(Console.ReadLine());
        
        foreach (char guessinputf in guesingWord)
        {
            Console.Write("- ");


        }
         for (int i=0; i<WordLenght; i++)
        {
            if (guesingWord.Contains (input))
            {

            Console.WriteLine("Correct answer!");
                Console.WriteLine(input);
        }
        }



    }




}




    







