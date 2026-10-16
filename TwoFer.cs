using System;
using System.Collections.Generic;
using System.Text;

namespace ExercismExercises
{
    public static class TwoFer
    {

        public static string Speak(string words = "you")
        {
            if (string.IsNullOrWhiteSpace(words))
            {
                words = "you";
            }
            return $"One for {words}, one for me.";

            throw new NotImplementedException("You need to implement this method.");
        }
    }
}