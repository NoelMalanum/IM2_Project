using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
     class Program
    {
        static void Main()
        {
            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

            List<List<double>> numbers = new List<List<double>>();
            double total = 0;
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}");
                List<double> rowList = new List<double>();

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number{j + 1}: ");
                    double value = double.Parse(Console.ReadLine());
                    rowList.Add(value);

                    total += value;
                    count++;
                }

                numbers.Add(rowList);
            }

            Console.WriteLine("\nThe numbers are:");
            foreach (var row in numbers)
            {
                foreach (var num in row)
                {
                    Console.Write($"{num:0.0} ");
                }
                Console.WriteLine();
            }

            double average = total / count;
            Console.WriteLine($"\nSum: {total:0.0} ; Average: {average:0.0}");

            Console.ReadKey();
        }
    }
}
