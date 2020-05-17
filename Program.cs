using System;
using System.Collections.Generic;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int num = 123;
            //int num = 120;
            //int num = -123;
            //int num = 900000;
            int num = 1534236469;
            Int64 revereInt = ReverseInt(num);
            Console.WriteLine(revereInt);


            Console.ReadKey();

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

        

    }

        
}
