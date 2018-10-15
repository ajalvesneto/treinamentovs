using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "1234";
            String num2 = "5678";
            int n = int.Parse(num);
            int y = int.Parse(num2);
            Console.WriteLine(num + " " + num2 + "=" + (num + num2));
            Console.WriteLine(n + " " + y + "=" + (n + y));
            Console.ReadKey();
        }
    }
}
