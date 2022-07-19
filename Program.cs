using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {   
                        
            string frase = Console.ReadLine();

            string resultado = InverterCaractere(frase);

            Console.WriteLine(resultado.ToUpper());  

        }

       

        public static string InverterCaractere(string inverterCaractere)
        {
            var inverter = new char[inverterCaractere.Length];
            for (int i = inverterCaractere.Length - 1, destIndex = 0; i >= 0; i--, destIndex++)
            {
                inverter[destIndex] = inverterCaractere[i];
            }
            return new string(inverter);
       }   
    }
}
