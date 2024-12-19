using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session2
{
    namespace TrainingPrograming.Session2
    {
        public class Cursant
        {
            string numeCursant;
            string prenumeCursant;
            int varsta;
            long cnp;
            bool esteActiv;
            char gen;
            float nota;
            double inaltime;

            [Test]
            public void metodaTest()
            {
                numeCursant = "Nicoria";
                prenumeCursant = "Lorena";
                varsta = 39;
                cnp = 123456789;
                esteActiv = false;
                gen = 'F';
                nota = 7.10f;
                inaltime = 1.73;

                Console.Write("Nume cursant: " + numeCursant + " " + prenumeCursant + "\n");
                // Console.WriteLine("Prenumele: " + prenumeCursant);
                Console.WriteLine("Varsta: " + varsta + " " );

                Console.WriteLine("CNP: " + cnp);
                Console.WriteLine("Activ: " + esteActiv + "\n");
                Console.WriteLine("Nota: " + nota);

            }
            


        }
    }
}
