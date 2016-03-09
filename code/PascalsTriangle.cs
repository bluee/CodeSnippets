using System;

namespace ConsoleApplication
{
    class Program
    {
        public static void PascalsTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int c = 1;
                for (int k = 0; k <= i; k++)
                {
                    Console.Out.Write(c.ToString() + " ");
                    c = c * (i - k) / (k + 1);
                }
                Console.Out.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            PascalsTriangle(n);
            Console.ReadLine();
        }
    }
}
