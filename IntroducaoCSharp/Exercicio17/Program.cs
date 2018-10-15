using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("João", 25);
            Console.WriteLine(pessoa.nome);
            Console.WriteLine(pessoa.idade);
            Console.ReadKey();


            Ferrari ferrari = new Ferrari("IAA-7239");
            ferrari.mostrarPlaca();
            Console.ReadKey();
        }
    }
}
