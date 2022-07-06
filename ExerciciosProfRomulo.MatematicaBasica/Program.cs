using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.MatematicaBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 3- No projeto MatematicaBasica crie um 
            Programa que calcule a soma de dois números inteiros.
            Considere que o usuário vai digitar esses dois números.*/

            int num1, num2;
            int sum;

            Console.WriteLine("Calcule a soma de dois numeros:");
            Console.WriteLine("Digite o primeiro numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine($"O resultado da soma entre {num1} + {num2} é = {sum}");
            Console.ReadKey();

        }
    }
}
