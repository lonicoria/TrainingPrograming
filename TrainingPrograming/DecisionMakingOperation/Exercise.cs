using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.DecisionMakingOperation
{
    public class Exercise
    {
        [Test]
        public void TestMethod()
        {
            //VerificareNumar(10, 25);
            // VerificareNumar(21, 2);
            CompareDigits(5);
            //VerificareMasina("BMW");
            VerificareMasina("Dacia");


        }
        public void VerificareNumar(int x, int y)
        {

            if (x < y)
            {
                Console.WriteLine($"Numarul {x} este mai mic decat numarul {y}");
            }
            else
            {
                Console.WriteLine($"Numarul {x} este mai mare decat numarul {y}");
            }


        }

        public void CompareDigits(int x)
        {

            if (x < 5)
            {
                Console.WriteLine($"Numarul {x} este mai mic decat 5");

            }
            else if (x > 5)
            {
                Console.WriteLine($"Numarul {x} este mai mare decat 5");
            }
            else
            {
                Console.WriteLine($"Numarul {x} este egal cu 5");
            }
        }

        public void VerificareMasina(string masina)
        {
            switch (masina)
            {
                case "Mercedes":
                    Console.WriteLine("Mercedes Este disponibil in stoc");
                    break;
                case "Opel":
                    Console.WriteLine("Opel Este disponibil in stoc");
                    break;
                case "BMW":
                    Console.WriteLine("BMW Este disponibil in stoc");
                    break;
                default:
                    Console.WriteLine("Marca nu este disponibila");
                    break;


            }
        }
    }
}


