using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session2
{
    public class Homework1
    {
        string firstName = "Lorena";
        string lastName = "Nicoria";
        int age = 39;
        string gender = "Female";

        public int AgeIn20Years
        {
            get { return age + 20; }
        }

        [Test]
        public void practiceTest()
        {
            Console.WriteLine("Hello, " + "\n" + "Please input your First Name: " + "\n" + firstName);
            Console.WriteLine();
            Console.WriteLine("Please input your Last name: " + "\n" + lastName);
            Console.WriteLine();
            Console.WriteLine("Please input your age: " + "\n" + age);
            Console.WriteLine();
            Console.WriteLine("Please input your gender: " + "\n" + gender);
        }
        
    }
}
       