﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace weeklyChallenges04
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int numTotal = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    numTotal += num;
                }
                else
                {
                    numTotal -= num;
                }
            }
            return numTotal;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> intList = new List<int>();
            intList.Add(str1.Length);
            intList.Add(str2.Length);
            intList.Add(str3.Length);
            intList.Add(str4.Length);

            return intList.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> intList = new List<int>();
            intList.Add(number1);
            intList.Add(number2);
            intList.Add(number3);
            intList.Add(number4);

            return intList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 & sideLength1 + sideLength3 > sideLength2 & sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;

        }

        public bool IsStringANumber(string input)
        {
            double n = 0;
            return double.TryParse(input, out n);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int numOfNull = 0;
            int numOfNotNull = 0;
            foreach(object obj in objs)
            {
                if(obj != null)
                {
                    numOfNotNull++;
                }
                else
                {
                    numOfNull++;
                }

            }
            if(numOfNull > numOfNotNull)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers is null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] %2 ==0)
                {
                    List<int> evens = numbers.Select(x => x).Where(x => x % 2 == 0).ToList();
                    return evens.Average();
                }
            }
            return 0;
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else if(number <0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {

                int i = 0;
                int fact = number;
                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }

                return Math.Abs(fact);
            }
        }
    }

}
