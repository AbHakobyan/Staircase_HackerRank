using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase_HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            staircase(n);

        }

        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
        }
    }
}
