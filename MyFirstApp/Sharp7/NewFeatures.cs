using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace MyFirstApp.Sharp7
{
    public class NewFeatures
    {
        public void StudentInfo(out string StudentName, out int StudentAge, out int StudentGrate)
        {
            StudentName = " John";
            StudentAge = 30;
            StudentGrate = 88;
        }
        public  List<Student> Student = null;
        public NewFeatures()
        {
            var s = new List<Student>
            {
                new Student()
                {
                    Name="Steve",
                    Age = 30,
                    Grate = 200

                },
                new Student()
                {
                    Name="Pavel",
                    Age = 30,
                    Grate = 200

                },
                new Student()
                {
                    Name="Lana",
                    Age = 25,
                    Grate = 200

                }
            };
            Student = s;
        }
        public void GetStudentInfo(Student student)
        {
            switch (student)
            {
                case Student s when (s.Age == 30 && s.Name.Contains("Steve")):
                    Console.WriteLine($"student {s.Name} with age {s.Age} have greate {s.Grate}");
                    break;
                case Student s when (s.Age == 25):
                    Console.WriteLine($"student {s.Name} with age {s.Age} have greate {s.Grate}");
                    break;
                default:
                    break;
            }
        } 
        public (string, int, int) ReturnStudentInfo()
        {
            return ("Steven", 35, 100);
        }

    }


    public class Student
    {
        private int Salery;
        public int salery
        {
            get => Salery;
            set => Salery = value;
        }
        public void PrintName()
        {
            Console.WriteLine($"Youy mutherFucker {Name}");
        }
        public Student(string name) => Name = name;
        public Student()
        {
                          
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grate { get; set; }
        
       public string GetStudentName()
        {
            return Name ?? throw new TypeInitializationException("MyFirstApp.Sharp7.Student.Name", new Exception("Name has to be initialize before callin it"));
        }
        public void StudentNameReSharp() => Console.WriteLine($"Student name is {Name}");
    }
}
