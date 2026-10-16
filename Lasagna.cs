using System;
using System.Collections.Generic;
using System.Text;

namespace ExercismExercises
{
    class Lasagna
    {
        public int ExpectedMinutesInOven() => 40;

        public int RemainingMinutesInOven(int actualMinutes) => ExpectedMinutesInOven() - actualMinutes;


        public int PreparationTimeInMinutes(int numbOflayers) => numbOflayers * 2;


        public int ElapsedTimeInMinutes(int layersCount, int timeInOven)
        {
            int time = PreparationTimeInMinutes(layersCount);
            return time + timeInOven;
        }
    }
}
