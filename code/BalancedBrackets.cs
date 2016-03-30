using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(hasBalancedBrackets("[](){}<>"));
            Debug.WriteLine(hasBalancedBrackets("([{<>}])"));
            Debug.WriteLine(hasBalancedBrackets("([{<>}]("));
        }

        private static char[] allowedOpeningBrackets = { '(', '{', '[', '<' };
        private static char[] allowedClosingBrackets = { ')', '}', ']', '>' };

        static bool hasBalancedBrackets(string s)
        {
            Func<char, bool> isOpeningBracket = (x) => (Array.IndexOf(allowedOpeningBrackets, x) >= 0);
            Func<char, bool> isClosingBracket = (x) => (Array.IndexOf(allowedClosingBrackets, x) >= 0);
            Stack<int> brackets = new Stack<int>();

            for(int i=0; i<s.Length;i++)
            {
                char chr = s[i];
                int index = Array.IndexOf(allowedOpeningBrackets, chr);

                if (isOpeningBracket(chr))
                    brackets.Push(index);  // Add index to stach
                else
                if (isClosingBracket(chr))
                {
                    index = Array.IndexOf(allowedClosingBrackets, chr);
                    if (index != -1 && (brackets.Count == 0 || brackets.Pop() != index))
                        return false;
                }
            }
            return (brackets.Count == 0);
        }
    }
}
