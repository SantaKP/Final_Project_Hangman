using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_DB
{
    class DB_analysis
    {
        public static string  DataBases()
        {
            char mainInput = InputVal.input();
           
            string secretWord;
            //string secretWord2;
            //string secretWord3;
            
                if (mainInput == 'A')
                {
                    string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\splen\Documents\Final_Project_Hangman\Animals.csv");

                    var animalNames = new List<string>();


                    int rnd = new Random().Next(0, 11);


                    for (int i = 0; i < csvLines.Length; i++)
                    {

                        string[] rawData = csvLines[i].Split(';');// spotting in rows
                        animalNames.Add(rawData[0]);

                        for (int j = 0; j < rawData.Length; j++)

                        {
                            /* Console.WriteLine(rawData[j]);*///writes all csv file in line

                        }

                    }
                    string guessingWord = animalNames[rnd];
                    
                    return guessingWord;
                }

                if (mainInput == 'F')
                {

                    string[] fruitLines = System.IO.File.ReadAllLines(@"C:\Users\splen\Documents\Final_Project_Hangman\Fruits.csv");
                    var fruitNames = new List<string>();
                    int rndfruit = new Random().Next(0, 5);

                    for (int f = 0; f < fruitLines.Length; f++)
                    {

                        string[] fruitData = fruitLines[f].Split(';');// spotting in rows
                        fruitNames.Add(fruitData[0]);

                        for (int u = 0; u < fruitData.Length; u++)

                        {
                            /* Console.WriteLine(rawData[j]);*///writes all csv file in line

                        }

                    }
                    string guessingWord = fruitNames[rndfruit];
                    return guessingWord;
                }

                if (mainInput == 'V')
                {   
                    string[] vegLines = System.IO.File.ReadAllLines(@"C:\Users\splen\Documents\Final_Project_Hangman\vegetables.csv");
                    var vegNames = new List<string>();
                    int rndVeg = new Random().Next(0, 6);

                    for (int k = 0; k < vegLines.Length; k++)
                    {

                        string[] vegData = vegLines[k].Split(';');// spotting in rows
                        vegNames.Add(vegData[0]);

                        for (int l = 0; l < vegData.Length; l++)

                        {
                            /* Console.WriteLine(rawData[j]);*///writes all csv file in line

                        }


                    }
                    string guessingWord = vegNames[rndVeg];
               
                    return guessingWord;
                }

                return string.Empty;
        }

 
        
    }
}

       














    

 













    

