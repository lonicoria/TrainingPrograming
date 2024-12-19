using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Homework1.Tema
{
    public class Test
    {
        public void Tema()
        {
            // Create an instance of the Browser class with initial dimensions
            Browser myBrowser = new Browser(900, 500); // Initial dimensions

            // Change browser resolution to 1920x1080
            myBrowser.ChangeWindowWidth(1920);
            myBrowser.ChangeWindowHeight(1080);

            // Display the updated resolution
            myBrowser.DisplayResolution();
        }
    }
    public class Browser
    {

        // Variables for window width and height
        public int WindowWidth { get; private set; }
        public int WindowHeight { get; private set; }

        // Constructor to initialize width and height
        public Browser(int width, int height)
        {
            WindowWidth = width;
            WindowHeight = height;
        }

        // Method to change window width
        public void ChangeWindowWidth(int newWidth)
        {
            WindowWidth = newWidth;
            Console.WriteLine($"Window width changed to: {WindowWidth}");
        }

        // Method to change window height
        public void ChangeWindowHeight(int newHeight)
        {
            WindowHeight = newHeight;
            Console.WriteLine($"Window height changed to: {WindowHeight}");
        }

        // Method to display browser resolution
        public void DisplayResolution()
        {
            Console.WriteLine($"Browser Resolution: {WindowWidth}x{WindowHeight}");
        }
    }
}


    
