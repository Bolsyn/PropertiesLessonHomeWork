using System;

namespace PropertiesLessonHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray ra = new RangeOfArray(-5, 5);

            Console.WriteLine("Length of ra: ");

            for (int i = -5; i <= 5; i++)
                ra[i] = i;

            Console.Write("Contents of ra: ");
            for (int i = -5; i <= 5; i++)
                Console.Write(ra[i] + " ");

            Console.WriteLine("\n");

        }
    }
}
