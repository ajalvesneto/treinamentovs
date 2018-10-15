using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                int div = 10 / n;
                Console.WriteLine(div);

                if (div == 1)
                    throw new LinguagemException("erro teste");
            }
            catch
            {
                Console.WriteLine("Divisão por zero");
            }
            finally {
                
                Console.ReadKey();
            }
        }
    }
}
