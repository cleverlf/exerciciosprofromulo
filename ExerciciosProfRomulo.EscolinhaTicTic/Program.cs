using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 4 - Crie um programa para a escolinha Tic Tic
            calcular 3 notas de um aluno.
            Entrar com o nome do aluno e as três notas
            Mostrar a soma das notas e a média.*/

            string nomeAluno, result;
            double num1, num2, num3;
            double sum;
            double avg;


            Console.WriteLine("Digite o nome do Aluno:");
            nomeAluno = Console.ReadLine();
            Console.WriteLine("Digite as notas do aluno para obter a soma e a média:");
            Console.WriteLine("Nota 1:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2:");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3:");
            num3 = double.Parse(Console.ReadLine());
            sum = num1 + num2 + num3;
            avg = sum / 3;
            //result = avg >= 7 ? "Aprovado" : "Reprovado"; 
            if (avg >= 7)
            {
                result = "Aprovado";
            }
            else
            {
                result = "Reprovado";
            }
            //string avrs = Convert.ToString(avg);
            //string avrl = Convert.ToString(Convert.ToInt64(avg));
            //avrs.Substring(0, ( avrl.Length + 3 ))
            //Console.WriteLine($"{avrl.Length} \n {avrs.Length} {avg.ToString()}");
            Console.WriteLine($"O aluno {nomeAluno} com soma das notas {num1} + {num2} + {num3} " +
                $"é = {sum} e sua média é = {avg.ToString().Substring(0,(Convert.ToInt64(avg).ToString().Length) + 3 )}" +
                $", sendo assim ele foi {result}");
            Console.ReadKey();
        }
    }
}
