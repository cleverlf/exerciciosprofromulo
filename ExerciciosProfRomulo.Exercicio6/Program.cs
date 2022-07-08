using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numbers numbers = new Numbers();
            //double numero = Convert.ToDouble(Console.ReadLine());
            //numbers.tranfromToEven(numero);
            //numbers.decreaseTo(numero);
            //long n = numbers.factorial(numero);
            //Console.WriteLine($"\n{n}");
            //numbers.print();
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            long f = 1;


            /*for (int i = 1; i <= n; i++)
            {
                f *= i;
            }*/
            do
            {
                f *= i;
                i++;
            } while (i <= n);
           
            Console.WriteLine(f);
        }
        internal class Numbers 
        {
            private long[] num_m;
            public void tranfromToEven(double num) 
            {
                long count = 0; 
                for (long i = 1; i < Convert.ToInt64(num); i++)
                {
                    if (Convert.ToInt64(i) % 2 == 0) 
                    {
                        count++;
                    }
                }
                num_m = new long[count];
                for (long j = 1; j < Convert.ToInt64(num); j++)
                {
                    if (Convert.ToInt64(j) % 2 == 0)
                    {
                        num_m[(j-1)/2] = j;
                    }                   
                }
            }
            public void decreaseTo(double num) 
            {
                num_m = new long[Convert.ToInt64(num)];
                for (long i = num_m.Length ; i > 0; i--)
                {
                    num_m[i] = i ;
                }
            }
            public long factorial(double num) 
            {
                long kill = Convert.ToInt64(num);
                if (kill == 0)
                {
                    return 1;
                }
                else 
                {
                    return kill * factorial(num - 1);
                }
            }
            public long[] Num { get => num_m; }
            public void print() 
            {
                for (long i = 0; i < num_m.Length; i++)
                {
                    Console.WriteLine($"\n{num_m[i]}");
                }
            }

        }
    }
}
