using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;

            int nextDivisable = 0;
            do
            {
                if (startNumber % n == 0)
                {
                    nextDivisable = startNumber;
                } else
                {
                    startNumber++;
                }
            } while (nextDivisable == 0);

            return nextDivisable;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach ( Business business in businesses )
            {
                if (business.TotalRevenue == 0d)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }

            bool isAscendingOrder = true;
            for (int i = 0; i < numbers.Length; i++) {
                if(i != numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        isAscendingOrder = false; break;
                    }
                }
            }
            return isAscendingOrder;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int result = 0;
            for (int i = 1; i < numbers.Length; i++) {
                if (numbers[i - 1] % 2 == 0) {
                    result += numbers[i];
                }
            }
            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string result = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == " " || words[i] == "" || words[i] == "  ")
                {
                    continue;
                }

                string trimmedWord = words[i].Replace(" ", "");

                if (i < words.Length - 1)
                {
                    result += trimmedWord + " ";
                }
                else
                {
                    result += trimmedWord + ".";
                }
            }

            return result;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var result = new List<double>();
            if (elements == null || elements.Count < 4)
            {
                return result.ToArray();
            }

            for (int i = 3; i < elements.Count;) {
                result.Add(elements[i]);
                i += 4;
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++) { 

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) {
                        continue;
                    } else if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                    
                }
            
            }

            return false;
        }
    }
}
