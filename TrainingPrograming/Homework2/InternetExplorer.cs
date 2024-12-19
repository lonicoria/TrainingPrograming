using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Homework2.D
{
    public class InternetExplorer
    {

        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;
    
     public void DisplayMultipleTimes()
        {
            if (WindowWidth_int > 1920)
            {
                int count = 0;
                while (count < 3)
                {
                    Console.WriteLine($"Window width: {WindowWidth_int}");
                    count++;
                }
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Window width: {WindowWidth_int}");
                }
            }
        }
    }
}

