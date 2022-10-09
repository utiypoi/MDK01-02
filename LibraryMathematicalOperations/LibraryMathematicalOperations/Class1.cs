using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMathematicalOperations
{
    public class MathematicalOperation
    {
        public static double AdditionOperation(double a, double b, double c)
        {
            return(a+b+c);
        }

        public static double MultiplicationOperation(double a, double b, double c) {
            return(a*b*c);
        }

        public static double ExponentiationOperation(double a, double b, double c) {
            return(Math.Pow(a,Math.Pow(b,c)));
        }

        public static double SubtractionOperation(double a, double b, double c) {
            return(a - b - c);
        }

        public static double DivisionOperation(double a, double b, double c)
        {
            return(a/b/c);
        }
    }
}
