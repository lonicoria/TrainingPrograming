using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Homework2.B
{
    public class Firefox
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void ConvertAndDisplay()
        {
            // Convert int to string
            WindowWidth_string = WindowWidth_int.ToString();
            Console.WriteLine($"Converted int to string: {WindowWidth_string}");

            // Convert string to double
            WindowWidth_double = Convert.ToDouble(WindowWidth_string);
            Console.WriteLine($"Converted string to double: {WindowWidth_double}");

            // Convert double to int
            int widthInt = Convert.ToInt32(WindowWidth_double);
            Console.WriteLine($"Converted double to int: {widthInt}");
        }
    }
}

