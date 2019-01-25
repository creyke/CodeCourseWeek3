using System;

namespace CodeCourseWeek3
{
    class Cow
    {
        public static void Moo(int cow)
        {
            Console.WriteLine($"Cow number #{cow} says Moo!");
        }
        
        public static void Milk(int cow)
        {
            Console.WriteLine($"Now milking cow #{cow}!");
        }
    }
}