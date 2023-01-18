

using System.Transactions;

class Hangman_template
{

    static void Main(string[] args) { 

        // i left animal names in bracket so we would know, when finish we can take them out.

    string[] clue = { "Funny videos (cat)" , "not welcome  in house (rat)", "Tom`s favorite kind (mouse)", "Wild and free (horse)", "Never drinks warm coffee (giraffe)", "fast and fearful (rabbit)", "Majestic (deer)", "Can`t jump (elephant)", "No gray zone(zebra)", "Jups and swims (dolphin)" };
    int[] numb = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        string clueNumb;
        Console.WriteLine("Please enter number 1-10:");
       
        clueNumb = (clue[int.Parse(Console.ReadLine())]);
        Console.WriteLine("Your clue is:");
        Console.WriteLine(clueNumb);

        Console.WriteLine("The game starts now!");

        Console.WriteLine("Please enter your first guess: ");

        Console.ReadLine();



       






    }

  
    






}