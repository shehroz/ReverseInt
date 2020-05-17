using System;
using System.Collections.Generic;

namespace LengthofTheLongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "pwwkew";
            //int len = largestSubStr(str,str.Length);
            //Console.WriteLine("Length of the longest substring:[" + len + "]");
            //int num = 123;
            //int num = 120;
            //int num = -123;
            //int num = 900000;
            int num = 1534236469;
            Int64 revereInt = ReverseInt(num);
            Console.WriteLine(revereInt);


            Console.ReadKey();

        }
        //abcabcbb
        public static int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            int j = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if(map.ContainsKey(s[i]))
                {
                    j = Math.Max(j, map[s[i]] + 1);
                }
                map.Add(s[i],i);
                max = Math.Max(max, i - j + 1);
            }

            return max;
        }

        static int largestSubStr(string str, int n)
        {
            int len = 0;

            int i = 0;
            while (i < n)
            {

                // Valid sub-string exists from index 
                // i to end 
                int end = getEndingIndex(str, n, i);

                // Update the length 
                len = Math.Max(end - i + 1, len);
                i = end + 1;
            }
            return len;
        }
        static int getEndingIndex(string str, int n, int i)
        {
            i++;
            while (i < n)
            {
                char curr = str[i];
                char prev = str[i - 1];

                // If the current character appears after 
                // the previous character according to  
                // the given circular alphabetical order 
                if ((curr == 'a' && prev == 'z') ||
                    (curr - prev == 1))
                    i++;
                else
                    break;
            }
            return i - 1;
        }

        public static int ReverseInt(int x)
        {
            bool IsNegativeNumber = false;
            int posNum = 0;
            if (x > 0)
                posNum = x;
            else
            {
                posNum = x * (-1);
                IsNegativeNumber = true;
            }
            char[] charArray = posNum.ToString().ToCharArray();
            int len = charArray.Length - 1;
            for (int i = 0; i < charArray.Length/2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[len];
                charArray[len] = temp;
                len--;
            }

            string res = new string(charArray);
            int outputInt;
            if (!IsNegativeNumber)
            {
                int.TryParse(res, out outputInt);
            }
            else
            {
                int.TryParse(res, out outputInt);
                outputInt = outputInt * (-1);


            }
            return outputInt;
        }

        public static int ReverseInt2(int x)
        {
            bool IsNegativeNumber = false;
            string s = x.ToString();
            return 0;

        }

    }

        
}
