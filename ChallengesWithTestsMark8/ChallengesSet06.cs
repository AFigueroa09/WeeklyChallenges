using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {

            if (word == null || words == null || words.Count() == 0) { 
                return false;
            }

            bool exists = false;
            foreach (string currentWord in words)
            {
                {
                    if (currentWord == null) { continue; }

                    if (ignoreCase == true)
                    {
                        if (currentWord.ToLower() == word.ToLower()) { return true; }
                    }
                    else
                    {
                        if (currentWord == word) { return true; }
                    }
                }
            }
            return exists;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null || str == string.Empty) {
                return -1;
            }

            IEnumerable<char> distincts = str.Distinct();

            if (distincts.Count() == 0)
            {
                return -1;
            }
            char lastDistinct = new char();

            foreach (char c in distincts) {
                int count = str.Count(x => x == c);
                if (count == 1) {
                    lastDistinct = c;
                }
            }
            return str.IndexOf(lastDistinct);
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxConsecutiveCount = 0;
            int currentCount = 0;
            int previousNum = int.MinValue;

            foreach (int num in numbers)
            {
                if (num == previousNum)
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                    previousNum = num;
                }

                if (currentCount > maxConsecutiveCount)
                {
                    maxConsecutiveCount = currentCount;
                }
            }

            return maxConsecutiveCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var result = new List<double>();
            if (elements == null || elements.Count < n || n < 1)
            {
                return result.ToArray();
            }

            for (int i = n - 1; i < elements.Count;)
            {
                result.Add(elements[i]);
                i += n;
            }

            return result.ToArray();
        }
    }
}
