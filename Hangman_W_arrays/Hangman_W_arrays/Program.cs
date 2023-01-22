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

          //Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" +
          //                        "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" +
          //                        "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");


        int WordLenght = guesingWord.Length;





    }







}