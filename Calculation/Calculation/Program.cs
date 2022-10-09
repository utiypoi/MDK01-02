using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения переменных a, b, c, отличные от нуля: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сложение: " + LibraryMathematicalOperations.MathematicalOperation.AdditionOperation(a,b,c) + 
                "\nВычитание: " + LibraryMathematicalOperations.MathematicalOperation.SubtractionOperation(a,b,c) + 
                "\nУмножение: " + LibraryMathematicalOperations.MathematicalOperation.MultiplicationOperation(a, b, c) + 
                "\nДеление: " + LibraryMathematicalOperations.MathematicalOperation.DivisionOperation(a,b,c) + 
                "\nВозведние в степень: " + LibraryMathematicalOperations.MathematicalOperation.ExponentiationOperation(a,b,c));
            Console.ReadKey();

        }
    }
}
