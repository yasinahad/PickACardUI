using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI /*change namespace of the CardPicker.cs file to match the namespace that Visual Studio used
                       * when it created the files in your new project so that you can use your CardPicker class in this new project*/
{
    public class CardPicker
    {
        static Random random = new Random();  //This is a static field called “random” that we’ll use to generate random numbers.

        /*The PickSomeCards method is a public static method that takes in a single integer parameter called numberOfCards.
        When the method is called, it first creates a new string array called pickedCards
        with a size equal to the value of the numberOfCards parameter.*/
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            /*for loop to iterate numberOfCards times. On each iteration, 
            it generates a random card by concatenating the result of calling the RandomValue method, 
            a string " of ", and the result of calling the RandomSuit method. 
            These strings are the constructed representation of the cards of the form "X of Y" where X can be Ace, King, Queen, Jack or any number from 2 to 10. Y can be Spades, Hearts, Clubs, Diamonds.*/
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards; /*the method returns the pickedCards array containing the numberOfCards random cards that have been generated.*/
        }

        private static string RandomSuit()
        {
            // get a random number from 1 to 4
            int value = random.Next(1, 5);
            // if it's 1 return the string Spades
            if (value == 1) return "Spades";
            // if it's 2 return the string Hearts
            if (value == 2) return "Hearts";
            // if it's 3 return the string Clubs
            if (value == 3) return "Clubs";
            // if we haven't returned yet, return the string Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            // get a random number from 1 to 13
            int value = random.Next(1, 14);
            // if it's 1 return the string Ace
            if (value == 1) return "Ace";
            // if it's 11 return the string Jack
            if (value == 11) return "Jack";
            // if it's 12 return the string Queen
            if (value == 12) return "Queen";
            // if it's 13 return the string King
            if (value == 13) return "King";
            return value.ToString();
            /*value is an int variable, but the 
            RandomValue method was declared with a string return 
            type, so we need to convert value to a string. You can add 
            .ToString() to any variable or value to convert it to a string*/
        }
    }
}
