using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxingUnboxing();
        }

        static void BoxingUnboxing() {
            int i = 123;
            object obj = i;

            obj = 213;
            i = (int)obj;

            Console.WriteLine(obj);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }

}
