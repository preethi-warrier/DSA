using System;
using System.Linq;
using System.Text;

namespace StringManipulation
{
    public class StringAlgorithms
    {
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
    }
}
