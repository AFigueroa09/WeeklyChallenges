using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers) {
                if (number % 2 == 0) {
                    sum += number;
                } else
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> stringList = new List<string> { str1, str2, str3, str4};
            stringList = stringList.OrderBy(x => x.Length).ToList();
            return stringList.First().Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int> { number1, number2, number3, number4 };
            var smallest = numbers.OrderBy(x => x).First();
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var validCombination1 = sideLength1 + sideLength2 > sideLength3;
            var validCombination2 = sideLength2 + sideLength3 > sideLength1;
            var validCombination3 = sideLength3 + sideLength1 > sideLength2;

            if (validCombination1 == true && validCombination2 == true && validCombination3 == true) 
            { 
                return true;
            } else { 
                return false; 
            }
        }

        public bool IsStringANumber(string input)
        {
            var intResult = int.TryParse(input, out var number1);
            var doubleResult = double.TryParse(input, out var number2);
            if (doubleResult == true || intResult == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullList = objs.Select(x => x == null).Where(x=> x == true).ToList();
            if(nullList.Count > objs.Length / 2) {
                return true;
            } else {
                return false; 
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers?.Length == 0 || numbers == null) {  return 0; }

            var evens = numbers.Where(x => x % 2 == 0);
            if(evens.Count() > 0)
            {
                return evens.Average();
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            if (number < 0) { throw new ArgumentOutOfRangeException("A negative value was provided to Factorial method"); }

            var result = 1;
            while (number > 1) { 
                result *= number;
                number--;
            }
            return result;
        }
    }
}
