using System;

namespace MyLibrary
{
    public static class MyMath
    {
        /// <summary>
        /// Возвращает факториал числа. В качестве аргумента могут быть переданы только положительные числа или 0.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double Factorial(double number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            if (number > 1)
            {
                var result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Возвращает число (number) возведенное в степень (exponent).
        /// </summary>
        /// <param name="number"></param>
        /// <param name="exponent"></param>
        /// <returns></returns>
        public static double Exponentiation(double number, int exponent)
        {
            var result = number;

            if (exponent >= 0)
            {
                for (int i = 1; i < exponent; i++)
                {
                    result *= number;
                }
                return result;
            }
            else
            {
                for (int i = -1; i > exponent; i--)
                {
                    result /= number;
                }
                return result;
            }
        }
    }
}
