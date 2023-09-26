using System;

namespace Interview
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Console.WriteLine(ReverseString("hello world"));
            //  Console.WriteLine(SwitchWord("hello world"));
            //  Console.WriteLine(RevStringWithLoop("Take my tissue"));
            // Console.WriteLine(IsPalindrome("abcba"));
            // Console.WriteLine(IsPalindrome("abcbd"));
            // Console.WriteLine(IsPalindromeNum(12321));
            // Console.WriteLine(IsPalindromeNum(12322));
            Console.WriteLine(SubstringCheck("hello king and queen"));
        }
        public static string RevStringWithLoop(string word)
        {
            string str = " ";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                str += word[i];
            }
            return str;
        }
        public static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        public static string SwitchWord(string sen)
        {
            string[] words = sen.Split();
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        public static bool IsPalindromeNum(int n)
        {
            string s = n.ToString();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;

        }
        public static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        public static string SubstringCheck(string input)
        {

            Console.WriteLine("enter some string");
            Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Put string only");
                return null;
            }

            Console.WriteLine("Choose the Length");
            if (!int.TryParse(Console.ReadLine(), out int len))
            {
                Console.WriteLine("put number");
                return null;
            }

            Console.WriteLine("Choose the length of the substring");
            if (!int.TryParse(Console.ReadLine(), out int end))
            {
                Console.WriteLine("ivalid number for substring ");
                return null;
            }
            if (len < 0 || end < 0 || len + end > input.Length)
            {
                Console.WriteLine("something when wrong with the len or the substring length");
                return null;
            }
            Console.WriteLine($" the number of the letters of the input is {input.Length} ");
            return input.Substring(len, end);

        }

    }
}
