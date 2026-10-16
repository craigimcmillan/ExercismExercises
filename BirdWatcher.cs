using System;
using System.Collections.Generic;
using System.Text;

namespace ExercismExercises
{
    class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            return new int[] { 0, 2, 5, 3, 7, 8, 4 };
        }

        public int Today()
        {
            return birdsPerDay[birdsPerDay.Length - 1];
        }

        public void IncrementTodaysCount()
        {
            birdsPerDay[birdsPerDay.Length - 1] = birdsPerDay[birdsPerDay.Length - 1] + 1;
        }

        public bool HasDayWithoutBirds()
        {
            foreach (int i in birdsPerDay)
            {
                if (i == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int CountForFirstDays(int numberOfDays)
        {
            int birdsCounted = 0;
            for (int i = 0; i < birdsPerDay.Length && i < numberOfDays; i++)
            {
                birdsCounted = birdsCounted + birdsPerDay[i];
            }
            return birdsCounted;
        }

        public int BusyDays()
        {
            int Count = 0;
            for (int i = 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] > 4)
                {
                    Count++;
                    ;
                }
            }
            return Count;
        }
    }
}
