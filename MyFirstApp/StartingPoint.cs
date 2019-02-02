using MyFirstApp.Delegate;
using MyFirstApp.Sharp7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class StartingPoint
    {
        
        static void Main(string[] args)
        {
          NewFeatures newFeatures = new NewFeatures();
            // var studentInfo = newFeatures.ReturnStudentInfo();
            //Console.WriteLine("The info of the Student : " + studentInfo);
            // (string name, int age, int grate)= newFeatures.ReturnStudentInfo();
            //if (age < 40)
            // {
            //   Console.WriteLine(name + " " + age + " " + grate);
            // }
            // else
            // {
            //    Console.WriteLine(" What a Fuck?");
            // }
            // newFeatures.StudentInfo(out string name, out int age, out int grate);
            //Console.WriteLine($" Student with name {name} have age {age} and grate {grate}");


            //newFeatures.GetStudentInfo(newFeatures.Student.First());

            //Delegate example for 2.0
            // Printer p = delegate (string Print)
            //{
            //    Console.WriteLine($"The value I need to print :{Print}");
            //};

            //p("Chica");
            // Delegate example for 1.0
            //Printer p = DelegateTry.PrintV;
            //p("Opa Chica");
            // MetodsFromClass.GenericCollectionCustomeClass();
            //MetodsFromClass.GenericCollection();
            //Console.WriteLine(MetodsFromClass.GetBrowsers(Browser.Chrome));
            Student s = new Student("Sooo");
            //{
            //    Name = "Steve"
            // };
            // Console.WriteLine(s.GetStudentName());
            s.PrintName();
            Console.ReadLine();
        }
    }
}
