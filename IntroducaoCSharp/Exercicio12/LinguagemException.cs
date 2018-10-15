using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class LinguagemException : Exception
    {
        public LinguagemException(String msg){
            Console.WriteLine(msg);
            Console.ReadKey();
        }

    }
}
