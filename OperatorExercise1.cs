using System;

namespace OperatorExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            namespace OperatorExercise
    namespace OperatorExercise
    {
        class Program
        {
            static void Main(string[] args)
            {
                int x = 7;
                int y = 8;

                int result = x + y;
                Console.WriteLine(result);
                int result2 = x * y;
                Console.WriteLine(result2);
                int result3 = x - y;
                Console.WriteLine(result3);
                int result4 = x / y;
                Console.WriteLine(result4);

                int a = 17;
                int b = 4;

                int result5 = a / b;
                int quotient = result5;
                int result6 = a % b;
                int remainder = result6;

                Console.WriteLine($"17/4 is {result5} remainder {result6}");

                var radius = double.Parse(Console.ReadLine());


                Double AreaOfCircle(double radius)
                {
                    return Math.PI * radius * Math.Pow(radius, 2);
                }

                var areaResult = AreaOfCircle(radius);

                Console.WriteLine("What is the Radius of your circle?");
                Console.WriteLine($"The area of a circle with a Radius of {radius} is {areaResult}");

            }
        }
    }



    }
}
        }
    }
}
