using StringCalculatorKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            char delimiter = ',';
            char[] charArray = input.ToCharArray();
            if(input.StartsWith("//"))
            {
                   // delimiter = charArray[2];
                    input = input.Remove(0, 2);
                var newdelimiter = input.Substring(0, 1);
                input = input.Replace(newdelimiter, ",");

            }


            input = input.Replace("\n", ",");
           
            if (IsEmptyString(input))
            {
                return 0;
            }
            String[] numbersArray = input.Split(new[] {delimiter },StringSplitOptions.RemoveEmptyEntries);
            var sum = SumNumbers(numbersArray);
            return sum;
        }
        private static String removeDelimeters(String input)
        {
            char[] charArray = input.ToCharArray();
            char back = ' ';
            String newStr = "";
            for (int i = 0; i < charArray.Length; i++)
            {
                back = charArray[i];
                if (back == '\n')
                {
                    newStr = newStr + ",";
                }
                else
                {
                    newStr = newStr + charArray[i];
                }
            }
            return newStr;
        }

        private static int SumNumbers(string[] numbersArray)
        {
            int sum = 0;
            int[] intArray; 
            for (int i = 0; i < numbersArray.Length; i++)
            {
                int current = int.Parse(numbersArray[i]);
                if (current > 0)
                {
                    sum = sum + current;
                }
                else
                {
                    //throw new NegativesNotAllowedException();
                }
            }

            return sum;
        }

        private static bool IsEmptyString(string input)
        {
            return input == "";
        }
    }
}
