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
            get
            {
                return age + 20;
            }
        }

        [Test]
        public void PracticeTest()
        {
            Console.WriteLine("Hello,");
            Console.WriteLine($"Please input your First Name: \n{firstName}");
            Console.WriteLine();
            Console.WriteLine($"Please input your Last Name: \n{lastName}");
            Console.WriteLine();
            Console.WriteLine($"Please input your Age: \n{age}");
            Console.WriteLine();
            Console.WriteLine($"Please input your Gender: \n{gender}");
            Console.WriteLine();
            Console.WriteLine($"Your age in 20 years will be: {AgeIn20Years}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Homework1 homework = new Homework1();
            homework.PracticeTest();
        }
    }
}



       