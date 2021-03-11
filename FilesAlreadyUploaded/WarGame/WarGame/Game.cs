using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Game
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        int playerOneScore;
        int playerTwoScore;
        Random rand;

        //Constructor - Sets the scores to 0 when a new game is created
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            rand = new Random();
        }

        public int RollDice(int numberOfSides)
        {
            //This method is complete! When called, it will return a random number.
            //You will need to pass in an integer as the parameter to represent the
            //number of sides of the dice being rolled.
            return rand.Next(numberOfSides);
        }

        //Don't change anything above this ^^^^^^^^^^^^


        //Member Methods - All your methods go below here!

        public int ChooseNumberOfSides()
        {
            //This method should prompt the user to enter the number of sides,
            //capture user input and return it after converting it to an integer.
            //This method only needs to be called once in RunGame(), but the returned
            //value should be captured as a variable that will be passed into the
            //RollDice() method each time it's called.
            
        }

        public void CompareRolls(int playerOneRoll, int playerTwoRoll)
        {




        }

        public void DisplayWinner()
        {




        }

        //This is the main method that is called in the Program when you press Start
        //Call your other methods inside this method
        public void RunGame()
        {
            




        }
    }
}
