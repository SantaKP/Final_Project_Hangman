using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hangman_DB
{
    class User_Input
    {

        public static string WhatToGuess()
        {

            Console.WriteLine("Please choose what to guess! Enter V - for vegetables; A - for animals and F - for fruit:");
            string whatToGuessInput = Console.ReadLine();

           

            string validChar = User_Input.WhatToGuess();
            char value = 'A';
            //char value1 = 'F';
            //char value2 = 'V';


            bool validChar = whatToGuessInput.Contains(value);

            if (validChar = true)
            {

                Console.WriteLine("Start Guessing:");
            }


            else Console.WriteLine("Input not valid please try agin:");


            return validChar;

        }



        public static void CharVal() 
            {
    //        string validChar = User_Input.WhatToGuess();
    //        char value = 'A';
    //        //char value1 = 'F';
    //        //char value2 = 'V';


    //bool strInput = validChar.Contains(value);

    //        if (strInput = true)
    //        {
                
    //            Console.WriteLine("Start Guessing:");
    //        }


    //        else  Console.WriteLine("Input not valid please try agin:");

            //return validChar;
            
            
               
  
        }









             
            //if (true)
            //{
            //    bool  strInput1 = whatToGuessInput.Contains(value1);
            //}
            //return whatToGuessInput1;
            //if (true)
            //{
            //    bool strInput2 = whatToGuessInput.Contains(value2);
            //}
            //return whatToGuessInput2;






        }



       
        







    }

