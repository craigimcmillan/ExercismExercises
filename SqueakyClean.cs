using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace ExercismExercises
{
    public static class SqueakyClean
    {
        public static string Clean(string squeakyClean)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < squeakyClean.Length; i++)
            {

                if (char.IsWhiteSpace(squeakyClean[i]))
                {
                    result.Append("_");
                }
                else if (char.IsControl(squeakyClean[i]))
                {
                    result.Append("CTRL");
                }
                else if (squeakyClean[i] == '-' && i + 1 < squeakyClean.Length)
                {
                    result.Append(char.ToUpper(squeakyClean[i + 1]));
                    i++;
                }
                else if (squeakyClean[i] >= 'α' && squeakyClean[i] <= 'ω')
                {
                    continue;
                }
                else if (char.IsLetter(squeakyClean[i]))
                {
                    result.Append(squeakyClean[i]);
                }
            }
            return result.ToString();
        }
    }
}
