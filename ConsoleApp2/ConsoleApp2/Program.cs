using ConsoleApp2;

class SecondTry
{

    public static void Main(string[] args)
    {

        //Console.WriteLine("What would you like to guess- animals, vegetables or fruits? :");
        //string theme = Console.ReadLine();

        //string rawCSV = System.IO.File.ReadAllText(@"C:\Users\splen\Documents\Final_Project_Hangman\data_base_second_try.csv");

        //Console.WriteLine(rawCSV);

        string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\splen\Documents\Final_Project_Hangman\data_base_second_try.csv");

        var animalNames = new List<string>();
         List <Animals> animals = new List<Animals>();
        
        int rnd = new Random().Next(0, 11);

        //Console.WriteLine(rnd);

        for (int i = 0; i < csvLines.Length; i++)
        {
           
            string[] rawData = csvLines[i].Split(';');// spotting in rows
            animalNames.Add(rawData[0]);

            for (int j = 0; j < rawData.Length; j++)

            {
               /* Console.WriteLine(rawData[j]);*///writes all csv file in line

            }

        }


        for (int i = 0; i < 1; i++)
        {

            //Console.WriteLine(animalNames[i]);
            Random randi= new Random(); //doesnt do anything
            int one = randi.Next(0, 11);
            for (int j = 0; j< 1; j++) 
            {
                //Console.WriteLine(animalNames[rnd]);

            }
            


        }


        

        string animalN  = animalNames[rnd];
        int lettersNmb = animalN.Length;



        char[] guessarray = new char[lettersNmb];
        //Console.WriteLine("Please guess an animal that lives in: " + animallist[rnd].habitat);
        Console.WriteLine("Please enter your guess (only letters): ");

        for (int p = 0; p < lettersNmb; p++)
            guessarray[p] = '-';
        int mistakes = 0;


        while (mistakes < 9)
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
            for (int j = 0; j < lettersNmb; j++)
            {
                if (playerGuess == animalN[j])
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
                    Console.WriteLine("|      LL       |");
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
                Console.WriteLine("The secret word was: " + animalN);
            }




        }
    }



    static string ToChar(string? v)
    {
        throw new NotImplementedException();
    }
}
   
