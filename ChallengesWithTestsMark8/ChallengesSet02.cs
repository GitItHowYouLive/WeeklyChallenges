using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return alphabet.Contains(char.ToLower(c));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers==null)
            {
                return 0;
            }
            double mini = int.MaxValue;
            double maxi = int.MinValue + 1;

            foreach (double number in numbers)
            {
                if (number < mini)
                    mini = number;
                if (number > maxi)
                    maxi = number;
            }

            return mini + maxi;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return sum;
            foreach(int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return sum;
            foreach (int num in numbers)
            {
                if ((num % 2) == 0)
                    sum += num;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
                return false;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum%2!=0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long total = 0;
            
            for(int i = 1; i<number; i+=2)
            {
                total++;
            }

            return total;
        }
    }
}
