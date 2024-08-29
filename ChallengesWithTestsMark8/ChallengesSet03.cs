using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var containsFalse = false;
            foreach(var val in vals)
            {
                if (val == false) { 
                    containsFalse = true;
                    break;
                }
            }
            return containsFalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            var sumOfOdd = 0;
            foreach (var val in numbers) {
                sumOfOdd += val;
            }
            if (sumOfOdd % 2 != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isValid = false;
            var containsUpper = false;
            var containsNumber = false;
            var containsLower = false;

            if (password == null) {
                isValid = false;
            } else
            {
                if (password.Any(char.IsUpper) == true)
                {
                    containsUpper = true;
                }
                if (password.Any(char.IsNumber) == true)
                {
                    containsNumber = true;
                }
                if (password.Any(char.IsLower) == true)
                {
                    containsLower = true;
                }
            }

            if(containsUpper == true && containsLower == true && containsNumber == true)
            {
                isValid = true;
            }

            return isValid;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> nums = new List<int>();

            for (int i = 1; i < 100; i++) {
                if (i % 2 != 0) {
                    nums.Add(i);
                }
            }
            return nums.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++) { 
                string word = words[i];

                words[i] = word.ToUpper();
            }
        }
    }
}
