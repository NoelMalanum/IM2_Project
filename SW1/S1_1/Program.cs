using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_1
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int count = 1;
            foreach (string s in numbers)
            {
                if (s == "") continue;
                int num = int.Parse(s);
                Console.WriteLine($"{count}. {num}\t" + (IsPrime(num) ? "Prime" : "Composite"));
                count++;
            }
            Console.ReadKey();
        }
    }
}
