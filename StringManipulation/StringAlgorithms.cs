using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringManipulation
{
    public class StringAlgorithms
    {
        private static char[] special_characters = new char[] 
        { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };
        //1 upper case, 1 lower case,1 number
        public static bool IsPasswordComplex(string str)
        {
            if(string.IsNullOrEmpty(str)) return false;
            if (str.Any(char.IsUpper) && str.Any(char.IsLower) && str.Any(char.IsDigit))
                return true;
            return false;
        }

        public static bool IsCharAtEvenIndex(string str,char input)
        {
            if(string.IsNullOrEmpty(str))return false;
            string inputStr = char.IsUpper(input) ? str.ToUpper() : str.ToLower();
            for(int i = 0; i < inputStr.Length; i+=2)
            {
                if (inputStr[i] == input) return true;
            }
            return false;
        }
        public static string ReverseString(string input)
        {
            if(string.IsNullOrEmpty(input)) return input;
            //option1
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ReverseStringUsingStringBuilder(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            StringBuilder builder = new StringBuilder();
            for(int i = input.Length-1; i >=0; i--)
            {
                builder.Append(input[i]);
            }
            return builder.ToString();
        }

        public static string ReverseSentence(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            var words = input.Split(' ');
            StringBuilder builder = new StringBuilder();
            foreach(var word in words)
            {
                builder.Append(ReverseString(word));
                builder.Append(' ');
            }
            return builder.ToString().Trim();
        }

        /*
     * Complete the 'camelcase' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */
        public static int FindCamelCaseWords(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            //camelCase
            var words = s.Split(s.Where(char.IsUpper).ToArray());
            return words.Count();
        }
        /*
         * Complete the 'minimumNumber' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. STRING password
         */
        public static int MinimumNumber(int n, string password)
        {
            int minNum = 0;
            if (string.IsNullOrEmpty(password)) return minNum;
            // Return the minimum number of characters to make the password strong
            if (!password.Any(char.IsUpper))
                minNum++;
            if (!password.Any(char.IsLower))
                minNum++;
            if (!password.Any(char.IsDigit))
                minNum++;
            if (!password.Any(c => special_characters.Contains(c)))
                minNum++;
            if (minNum + n < 6)
                minNum += 6 - (minNum + n);
            return minNum;
        }
        public static int Anagram(string s)
        {
            if (string.IsNullOrEmpty(s)) return -1;
            if (s.Length % 2 != 0) return -1;
            var part1 = s.Substring(0, s.Length / 2);
            var part2 = s.Substring(s.Length / 2);

            var x =  part1.Where(c =>
            {
                if (part2.Contains(c))
                {
                    part2 = part2.Remove(part2.IndexOf(c));
                    return true;
                }
                return false;
            });
            return x.Count();
        }
    }
}
