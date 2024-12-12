using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session2.Metoda.HomeworkMetoda
{
    static class Person
    {
        [Test]
        

        public static void DisplayUserDetails()
        {
            Console.WriteLine("The person's details are as follows: \n " + "- First Name: " + FirstName + "\n - Last Name: " + LastName + "\n - Gender: " + Gender);
            Console.WriteLine("You will be " + AgeIn20Years + " years old in " + "15 years!");

        }


        public static string FirstName = "Lorena";
        public static string LastName = "Nicoria";
        public static string Gender = "Female";
        public static int Age = 39;



        public static int AgeIn20Years
        {
            get
            {
                return Age + 20;
            }


        }
    }

    }
