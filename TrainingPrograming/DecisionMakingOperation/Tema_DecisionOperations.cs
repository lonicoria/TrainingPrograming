using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPrograming.Session2.Metoda.HomeworkMetoda;

namespace TrainingPrograming.DecisionMakingOperation
{
    public class Tema_DecisionOperations
    {

        public class Person
        {
            // Property to store the age of the person
            public int Age { get; set; }
            public string Gender { get; set; }


            // Method to determine and output the age category
            public void IsOld()
            {
                if (Age >= 100)
                {
                    Console.WriteLine("You are ancient!");
                }
                else if (Age >= 50)
                {
                    Console.WriteLine("You are old!");

                }
                else           //Age <50
                {
                    Console.WriteLine("You are still young!");
                }
            }

            public void ShowGender()
            {
                switch (Gender)
                {
                    case "Male":
                        Console.WriteLine("You are male!");
                        break;
                    case "Female":
                        Console.WriteLine("You are female!");
                        break;
                    default:
                        Console.WriteLine("You haven't specified your gender!");
                        break;
                }
            }



            [Test]

            public void TestMethod()
            {


                Person person1 = new Person { Age = 150, Gender = "Male" };
                person1.IsOld();
                person1.ShowGender();

                Person person2 = new Person { Age = 15, Gender = "Female" };
                person2.IsOld();
                person2.ShowGender();


                Person person3 = new Person { Age = 55, Gender = "Not relevant" };
                person3.IsOld();
                person3.ShowGender();



            }

        }

    }

}       
          

