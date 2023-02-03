using Hangman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Guess a word. Do you want to guess an ANIMAL(A), FRUIT(F) or VEGETABLE(V) ?");

            Guessing.WordGuess(args);

        }

    }
}
