using System;

namespace LevenshteinDistance
{
    internal class LevenshteinDistanceCalculator
    {
        internal int Calculate(string firstWord, string secondWord)
        {
            if(firstWord == secondWord)
                return 0;
            return 1;
        }
    }
}