using System;
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
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            return input.All(char.IsNumber);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {

            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }

}
