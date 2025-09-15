using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_2
{
    class Program
    {
        static (double peso, double yen) ConvertCurrency(double dollars)
        {
            double peso = dollars * 57.17;
            double yen = dollars * 146.67;
            return (peso, yen); 
        }

        static void Main()
        {
            Console.Write("Enter currency in ($): ");
            double dollars = double.Parse(Console.ReadLine());

            var result = ConvertCurrency(dollars);

            Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen(Y)");
            Console.WriteLine($"{dollars}\t\t{result.peso}\t\t{result.yen}");

            Console.ReadKey();
        }
    }
}