using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPrograming.Session2.Tema1;

namespace TrainingPrograming.Session2.Metoda.HomeworkMetoda
{
    public class Persoana
    {

        [Test]

        public void DisplayUserDetails()
        {
            Console.WriteLine("The person's details are as follows: \n " + "- First Name: " + FirstName + "\n - Last Name: " + LastName + "\n - Gender: " + Gender);
            Console.WriteLine("You will be " + AgeIn20Years + " years old in " + "15 years!");

        }
        
        string FirstName = "Lorena";
        string LastName = "Nicoria";
        int Age = 39;
        string Gender = "Female";

    public int AgeIn20Years
        {
            get
            {
                return Age + 20;
            }
        }

        
            
        }
    }


    

    