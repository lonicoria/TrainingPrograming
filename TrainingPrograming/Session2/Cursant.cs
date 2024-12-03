using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.Session2
{
    public class Cursant
    {
        string numeCursant;
        string prenumeCursant;
        int varsta;
        int cnp;
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
            var numarLung = 123456789;  //cand dam build la app va sti sa interpreteze tipul variabilei
            esteActiv = false;
            gen = 'F';
            nota = 7.10f;
            inaltime = 1.73;

            Console.Write("Nume cursant: " + numeCursant + " " + prenumeCursant + "\n");
           // Console.WriteLine("Prenumele: " + prenumeCursant);
            Console.Write("Varsta: " + varsta);
            Console.WriteLine("CNP: " + numarLung);
            Console.WriteLine("Activ: " + esteActiv + " ");
            Console.WriteLine("Nota: " + nota);
            
        }




    }
}
