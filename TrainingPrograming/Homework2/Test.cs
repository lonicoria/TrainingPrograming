using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPrograming.Homework1.Tema;
using TrainingPrograming.Homework2.B;
using TrainingPrograming.Homework2.C;
using TrainingPrograming.Homework2.D;

namespace TrainingPrograming.Homework2
{
    public class Test
    {

        [Test]
        public void metodaTest()
        {
            // Create objects for each class
            Browser browser = new Browser();
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            InternetExplorer internetExplorer = new InternetExplorer();

            // Set values 1920 for Firefox object for all variables
            firefox.WindowWidth_int = 1920;
            firefox.WindowWidth_double = 1920;
            Console.WriteLine("For Firefox:");
            firefox.ConvertAndDisplay();

            // Set values for Chrome object
            chrome.WindowWidth_int = 2000;
            Console.WriteLine("\nFor Chrome:");
            chrome.CheckWindowWidth();

            // Set values for InternetExplorer object
            internetExplorer.WindowWidth_int = 1800;
            Console.WriteLine("\nFor Internet Explorer:");
            internetExplorer.DisplayMultipleTimes();
        }
    }
}

