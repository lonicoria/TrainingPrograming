using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session2.Metoda.HomeworkMetoda
{
    static class PersonFinal
    {
        // Static attributes to store person's details
        static string FirstName = "Lorena";
        static string LastName = "Nicoria";
        static int Age = 39;
        static string Gender = "Female";

        // Static method to compute age + parameter
        public static int ComputeFutureAge(int years)
        {
            return Age + years;
        }

        // Static method to display person's details
        public static void DisplayUserDetails(int years)
        {
            Console.WriteLine("The person's details are as follows:");
            Console.WriteLine(" - First Name: " + FirstName);
            Console.WriteLine(" - Last Name: " + LastName);
            Console.WriteLine(" - Gender: " + Gender);
            Console.WriteLine("You will be " + ComputeFutureAge(20) + " years old in " + years + " years!");
        }

        public class PersonTest
        {
            [Test]
            public void TestDisplayUserDetails()
            {
                // Call the static method to test
                PersonFinal.DisplayUserDetails(20);
            }
        }
    }
}


