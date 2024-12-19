using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Homework1.Tema
{
    public class HomeworkPractice
    {
        
            // Fields for user details
            private string firstName = "Lorena";
            private string lastName = "Nicoria";
            private int age = 39;
            private string gender = "Female";

            // Property to calculate age in 20 years
            public int AgeIn20Years
            {
                get
                {
                    return age + 20;
                }
            }

            // Method to display user details
            public void DisplayDetails()
            {
                Console.WriteLine("Hello,");
                Console.WriteLine($"First Name: {firstName}");
                Console.WriteLine($"Last Name: {lastName}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Gender: {gender}");
                Console.WriteLine($"Your age in 20 years will be: {AgeIn20Years}");
            }

        // Entry point of the program
        [Test]
        public void PracticeTest()
        {
                // Create an instance of HomeworkPractice
                HomeworkPractice practice = new HomeworkPractice();

                // Display the details
                practice.DisplayDetails();
            }
        }
    }



