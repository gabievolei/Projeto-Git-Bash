using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] comidas = { "coxinha", "bolinha de queijo", "pão de queijo"};

            foreach(string comida in comidas)
            {
                Console.WriteLine($"As comidas são: {comida}") ;
            }

            Console.ReadKey();    
   
        }
    }
}
