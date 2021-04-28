using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           byte comprimento=0;
           byte largura=0;
           double area=0;

            Console.WriteLine("Programa para Calcular área!");
            Console.WriteLine("Insira o comprimento:");
            comprimento = byte.Parse(Console.ReadLine());
            Console.WriteLine("Insira a largura:");
            largura = byte.Parse(Console.ReadLine());
            area = comprimento * largura;
            
            Console.WriteLine($"A área total é {area}");
            Console.WriteLine("Fim do programa");
            Console.ReadKey();
               
            
            

        }
    }
}
