using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20     
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpressaoLambda();
            ExpressaoLambdaPratica();
            Console.ReadKey();
        }

        static void ExpressaoLambda() {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int numPars = nums.Count(n => n % 2 == 1);
            Console.WriteLine(numPars);
        }

        static void ExpressaoLambdaPratica() {
            var selecoes = new ArrayList(new string[] { "BRASIL","USA", "ALEMANHA", "AFRICA DO SUL"});

            var melhorSelecao = from string 
                                p in selecoes
                                where p == "BRASIL"
                                select p;
            Console.WriteLine(melhorSelecao);

        }


    }
}
