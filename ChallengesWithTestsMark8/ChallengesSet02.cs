using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int arrayLength = vals.Length;
            double remainder = arrayLength % 2;
            if (remainder > 0)
            {
                return false;
            } else
            {
                return true;
            }
            
        }

        public bool IsNumberEven(int number)
        {
            double remainder = number % 2;
            if (remainder != 0)
            {
                return false; } else
            {
                return true;
            }
        }

        public bool IsNumberOdd(int num)
        {
            double remainder = num % 2;
            if (remainder != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                double min = 0;
                double max = 0;
                for (int i = 0; i < numbers.Count(); i++)
                {
                    double number = numbers.ElementAt(i);

                    if (i == 0)
                    {
                        min = number;
                        max = number;
                    }
                    else
                    {
                        if (number < min)
                        {
                            min = number;
                        }

                        if (number > max)
                        {
                            max = number;
                        }
                    }
                }
                return min + max;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            if (length1 < length2)
            {
                return length1;
            } else
            {
                return length2;
            }
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            } else
            {
                return numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            foreach(int number in numbers)
            {
                if (IsNumberEven(number))
                {
                    sum += number;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false; 
            } else
            {
                int sum = numbers.Sum();
                return IsNumberOdd(sum);
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 2)
            {
                return 0;
            }
            else
            {
                long count = 0;
                for (int i = 2; i <= number; i += 2)
                {
                    count++;
                }
                return count;
            }
        }
    }
}
