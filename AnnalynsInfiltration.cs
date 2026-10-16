using System;
using System.Collections.Generic;
using System.Text;

namespace ExercismExercises
{
    static class AnnalynsInfiltration
    {
        public static bool CanFastAttack(bool knightIsAwake)
        {
            if (!knightIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException("Please implement the (static) AnnalynsInfiltration.CanFastAttack() method");
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (knightIsAwake || archerIsAwake || prisonerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }

            throw new NotImplementedException("Please implement the (static) AnnalynsInfiltration.CanSpy() method");
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if (prisonerIsAwake && !archerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException("Please implement the (static) AnnalynsInfiltration.CanSignalPrisoner() method");
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (petDogIsPresent && !archerIsAwake || !petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException("Please implement the (static) AnnalynsInfiltration.CanFreePrisoner() method");
        }
    }

}
