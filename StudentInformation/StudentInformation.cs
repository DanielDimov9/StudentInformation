using System;
using System.Collections.Generic;

namespace StudentInformation
{
    class StudentInformation
    {


        static void Main()
        {
            List<Student> students = new List<Student>();

            Student student = new Student("Ivan","Ivanov");
            student.Display();
            student.AgeId();
            StudentAddress str = new StudentAddress();
            str.FullAddress();
            student.AddScore("English", 5);
            student.AddScore("Math", 2);
            student.AddScore("Physics", 4);

            while (true)
            {
                Console.Write("Enter student number or 0 to exit: ");
                string numberToFind = Console.ReadLine();
                if (numberToFind == "0")
                {
                    break;
                }

                Console.WriteLine();
                

                Student s= students.Find(s => s.StudentNumber == numberToFind); 

                if (student != null)
                {
                    Console.WriteLine(student.ToString());
                    foreach (var score in student.Scores)
                    {
                        Console.WriteLine($"{score.Course,-10} {score.Value:0.00}");
                    }
                }
                else
                {
                    Console.WriteLine($"There is no student with student number = {numberToFind}");
                }
                Console.WriteLine();
                str.FullAddress();

            }
            












































        }




    }
}

