using System;

namespace Sh.Calculator
{
    public static class Calculator
    {
        public static double Addition(double a, double b, int digits = 3) => (a + b).Round(digits);

        public static double Subtraction(double a, double b, int digits = 3) => (a - b).Round(digits);

        public static double Multiplication(double a, double b, int digits = 3) => (a * b).Round(digits);

        public static double Division(double a, double b, int digits = 3) => (a / b).Round(digits);

        private static double Round(this double val, int digits) => Math.Round(val, digits);
    }
}