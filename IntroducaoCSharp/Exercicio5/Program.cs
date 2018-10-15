using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Antonio José Alves Neto";
            string[] nomes = nome.Split(' ');
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nome.TrimStart());
            Console.ReadKey();

            foreach (string nomeFor in nomes) {
                Console.WriteLine(nomeFor);
                Console.ReadKey();
            }
        }
    }
}
