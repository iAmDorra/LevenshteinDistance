using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace LevenshteinDistance
{
    [TestClass]
    public class LevenshteinDistanceCalculatorTest
    {
        [TestMethod]
        public void Should_return_zero_when_calculating_distance_with_same_word()
        {
            LevenshteinDistanceCalculator distanceCalculator = new LevenshteinDistanceCalculator();
            int disctance = distanceCalculator.Calculate("a", "a");
            Check.That(disctance).IsEqualTo(0);
        }

        [TestMethod]
        public void Should_return_one_when_calculating_distance_with_words_with_one_different_letter()
        {
            LevenshteinDistanceCalculator distanceCalculator = new LevenshteinDistanceCalculator();
            int disctance = distanceCalculator.Calculate("a", "b");
            Check.That(disctance).IsEqualTo(1);
        }

        [TestMethod]
        public void Should_return_one_when_calculating_distance_with_one_word_and_one_same_with_an_additional_letter()
        {
            LevenshteinDistanceCalculator distanceCalculator = new LevenshteinDistanceCalculator();
            int disctance = distanceCalculator.Calculate("a", "ab");
            Check.That(disctance).IsEqualTo(1);
        }
    }
}
