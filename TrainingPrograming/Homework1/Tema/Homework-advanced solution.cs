using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Homework1.Tema1
{

    public class Homework
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            Person person = new()
            {
                FirstName = "Jane",
                LastName = "Doe",
                Age = 39,
                Gender = "Female"
            };

            Console.WriteLine("\nYour details are as follows:");
            Console.WriteLine("\t- First Name: " + person.FirstName);
            Console.WriteLine("\t- Last Name: " + person.LastName);
            Console.WriteLine("\t- Gender: " + person.Gender);
            Console.WriteLine("\t- Age: " + person.Age);

            var ageIn20Years = CalculateAgeIn20Years(person.Age);

            Console.WriteLine("\nYou will be " + ageIn20Years + " years old in 20 years!");
        }

        public static int CalculateAgeIn20Years(int currentAge)
        {
            return currentAge + 20;
        }
    }
}
