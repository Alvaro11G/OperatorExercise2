using System;

namespace OperatorExercise2
{
    class Program
    {
        public static double AreaOfCircle(double radius)
        {
            double answer;

            answer = Math.PI * radius * radius;

            return answer;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double answer2 = AreaOfCircle(radius);

            Console.WriteLine("The area of a circle with radius of " + radius + " is " + answer2);

        }
    }
}
