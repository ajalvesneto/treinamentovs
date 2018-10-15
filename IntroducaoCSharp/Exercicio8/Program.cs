using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {

        static int somar(int a, int b) {

            return a + b;
        }

        static void Main(string[] args)
        {
            const int n = 2019;
            Console.WriteLine(n);
            Console.ReadKey();

            var soma = somar(10,20);
            Console.WriteLine(soma);
            if (soma > 30)
                Console.WriteLine("Maior que 30");
            else
                Console.WriteLine("Menor ou igual que 30");
            Console.ReadKey();
        }
    }
}
