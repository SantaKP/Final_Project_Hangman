using Hangman4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_I
{
    internal class GetItem
    {
        public static Item GetOneItem() //In this method I am opening one of three text files: Animals, Fruits, Vegetables.
                                        // Then I create the list of objects of the Class Item
                                        // afterwards I generate random number
                                        // and the method returns one random object.
        {

            string choice = UserInput.UserChoise();
            string fileName = "";                      //Create an empty file where afterwards the name of chosen group would be written 

            
            List<Item> listOfItems = new List<Item>(); // Creates the list of objects, of the class Item.

            if (choice.Contains("F"))
            {
                fileName = "Fruits.txt";
            }
            else if (choice.Contains("V"))
            {
                fileName = "Vegetables.txt";
            }
            else if (choice.Contains("A"))
            {
                fileName = "Animals.txt";
            }

            System.IO.StreamReader file = new System.IO.StreamReader(fileName);  // Read the file and display it line by line.


            string line;

            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(';');

                listOfItems.Add(new Item(words[0], words[1], words[2]));

            }

            file.Close();        

            int rnd = new Random().Next(0, listOfItems.Count);
            //Console.WriteLine(rnd);


            
            return listOfItems[rnd];
        }


    }

    
}
