using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session2.Metoda
{
    internal class MyFirstMethod
    {
        
        [Test]
        public void MetodaTest()
        {
            SumNumbers(); //apelez metoda fara params
            SumNumbers(25,38);   //apelez metoda cu params
            SumNumbers(5, 7, 18);
            int resultSum= GetResult(15,20,66);
            Console.WriteLine("The result sum is: " + resultSum);

        }

        public void SumNumbers()    // metoda fara parametrii
        {

            int number1 = 10;
            int number2 = 15;
            int sum = number1 + number2;

            Console.WriteLine("Rezultatul adunarii este: " + sum);
        }

        public void SumNumbers(int number1, int number2)  //metoda cu parametrii
        {
            int sum = number1 + number2;
            Console.WriteLine("The result is: " + sum);
        }

        public void SumNumbers(int number1, int number2, int number3)  //metoda cu 3 parametrii
        {
            int sum = number1 + number2+ number3;
            Console.WriteLine("The result is: " + sum);
        }

        public int GetResult(int number1, int number2, int number3) //metoda cu return, nu void
        {
            int sum = number1 + number2 + number3;
            return sum;
        }
    }
}
