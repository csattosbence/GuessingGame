using System;

namespace GuessDLL
{
    public class GameLogic
    {
        //The User have to determin the correct number with as few guess as possible
        //-------User sets the Intervall for the guessing game 
        //The Application evaluates the User guess and returns an answear
        //-------The Game stops when the user gives a correct guess

        /*There are three types of questions that the user can choose 1. Is the number is less then..
         *                                                            2. Is the number is greater then..
         *                                                            3. Is the number equals to ...
         */

        public enum GuessType
        {
            GREATER,
            LESS,
            EQUALS

        }

        public int RandomNumber(int leftIntervall, int rightIntervall)
        {
            Random random = new Random();
            int randomNumber;
            return random.Next(leftIntervall, rightIntervall + 1);
        }

        public bool IsGuessCorrect(int guess, int randomNumber)
        {
            if (guess == randomNumber)
            {
                return true;
            }
            else return false;
        }
        public bool GuessAnswear(GuessType guessType, int guessNumber, int randomNumber)
        {
            if (guessType == GuessType.GREATER)
            {
                if (randomNumber > guessNumber)
                {
                    return true;

                }
                else if (randomNumber < guessNumber) return false;

            }
            if (guessType == GuessType.LESS)
            {
                if (randomNumber < guessNumber)
                {
                    return true;

                }
                else if (randomNumber > guessNumber) return false;

            }
            if (guessType == GuessType.GREATER)
            {
                if (randomNumber == guessNumber)
                {
                    return true;

                }
                else return false;
            }
            return false;
        }
    }
}
