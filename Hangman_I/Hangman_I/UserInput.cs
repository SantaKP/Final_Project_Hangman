using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_I
{
  class UserInput
    {
        public static string UserChoise() 
        { 
            //Console.WriteLine("Guess a word. Do you want to guess an ANIMAL(a) or FRUIT(f) or VEGETABLE(v) ?");
           

            
            
            string choiceInp = Console.ReadLine();
            bool wordValidation = choiceInp.All(Char.IsLetter);

          
            while (wordValidation == false)

           {
                Console.WriteLine("Please enter only letters:");
                Console.WriteLine("Please try again:");

                choiceInp = Console.ReadLine();
                
            }

            
            return choiceInp;

            







        }
       
    }



    
}
