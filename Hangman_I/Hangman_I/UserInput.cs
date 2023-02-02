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

                string choiceInp = Console.ReadLine();
                choiceInp = choiceInp.ToUpper();

                bool wordValidation = choiceInp.All(Char.IsLetter);



            do
            {



                Console.WriteLine("Input not valid! Please check if you entered one letter(ANIMAL(A), FRUIT(F) or VEGETABLE(V))!");
                Console.WriteLine("Please try again:");


            } while (wordValidation == false || choiceInp.Length == 2 || choiceInp.Length == 0);
             
            
             return choiceInp;
            
            
   


        }
    }
}


            

          
        
       
    



    

