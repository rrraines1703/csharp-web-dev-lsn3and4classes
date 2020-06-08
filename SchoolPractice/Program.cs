using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student ricky = new Student("Ricky", 1703, 1, 4.0);
            Console.WriteLine(ricky.ToString());

            Teacher jeff = new Teacher("Jeff", "Lin", "TA", 4);
            Console.WriteLine(jeff.ToString());

            Course lc101 = new Course();
            Console.WriteLine(lc101.ToString());

            ricky.AddGrade(4, 3);
            Console.WriteLine(ricky.Gpa);
            Console.WriteLine(ricky.GetGradeLevel());

        }
    }
}