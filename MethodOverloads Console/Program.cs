using System;

namespace MethodOverloads_Console
{
    class Program
    {
        public static int Add(int num1, int num2)

        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;
            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)

        {

            var x = 40;
            var y = 10;


            var answer = Add(x, y);

            var a = 10.6m;
            var b = 5.6m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($" int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
    }
}















