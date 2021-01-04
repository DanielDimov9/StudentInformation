using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInformation
{
    public class Student : Person
    {
        public int age = 19;
        public string studentNumber = "2022";

        public Student(string fn, string ln) : base(fn, ln)
        {
            Scores = new List<Score>();

        }
        public List<Score> Scores { get; set; }
        public decimal AverageScore
        {
            get
            {
                return Scores.Average(s => s.Value); 
            }
        }

        public string StudentNumber { get; set; }

     
        public int GetAge()
        {
            return age;
        }
        public string GetId()
        {
            return studentNumber;
        }

        public void AgeId()
        {
            Console.WriteLine("Age is :{0}", GetAge());
            Console.WriteLine("Student Number is :{0}", GetId());
        }
        public void AddScore(string course, decimal value)
        {
            this.Scores.Add(new Score { Course = course, Value = value });
        }
        public override string ToString()
        {
            return $"Student:{StudentNumber,-10}{firstName,-10}{lastName,-10} Average score ={AverageScore:0.00}";

        }














    }
}
