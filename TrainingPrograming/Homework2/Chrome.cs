﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Homework2.C
{
    public class Chrome
    {

        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;
    

    public void CheckWindowWidth()
        {
            if (WindowWidth_int > 1920)
            {
                Console.WriteLine($"Window width is: {WindowWidth_int}");
            }
            else
            {
                Console.WriteLine("Window width less than 1920");
            }
        }
    }
}

