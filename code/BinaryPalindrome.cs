using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(isBinaryPalindrome(10));
        }

       

        static bool isBinaryPalindrome(int x)
        {
            var binaryStr = Convert.ToString(x, 2);
            int len = binaryStr.Length;
            return binaryStr.Take(len / 2).All(p => p == binaryStr[--len]);
        }


    }
}
