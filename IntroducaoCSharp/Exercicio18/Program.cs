using System;
using System.Collections.Generic;


namespace Exercicio18
{
    class Program
    {
        public struct Carro
        {
            public string nome;
            public int ano;
        } 

        static void Main(string[] args)
        {
            Entidade pessoa = new Pessoa();
            pessoa.setNome("Joao");
            Console.WriteLine(pessoa.getNome());
            Console.ReadKey();


            Carro c = new Carro();
            c.nome = "teste";
            c.ano = 2017;

            List<int> lista = new List<int>();

            lista.Add(1);
            lista.Add(2);

            for (int i = 0; i < lista.Count; i++) {
                Console.WriteLine(lista[i]);
            }
            Console.ReadKey();
        }
        
    }
}
