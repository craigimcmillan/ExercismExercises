using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExercismExercises
{
    class JediksToys
    {
        private int METERS = 0;
        private int PERCENTAGE = 100;

        public static JediksToys Buy()
        {
            JediksToys car = new JediksToys();
            return car;
        }

        public string DistanceDisplay()
        {
            return $"Driven {METERS} meters";

        }

        public string BatteryDisplay()
        {
            if (PERCENTAGE > 0)
            {
                return $"Battery at {PERCENTAGE}%";
            }
            else
            {
                return $"Battery empty";
            }
        }

        public void Drive()
        {
            if (PERCENTAGE > 0)
            {
                METERS = METERS + 20;
                PERCENTAGE = PERCENTAGE - 1;
            }
        }
    }
}
