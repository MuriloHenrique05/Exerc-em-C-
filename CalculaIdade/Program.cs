using System;

namespace CalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Console.WriteLine("Pessoa 1 : " + p1.Nome + "Nascimento : " + p1.AnoNascimento);
            Console.ReadKey();

            Console.WriteLine("Programa que calcula a Idadde de uma Pessoa");

            Console.WriteLine("Nome da pessoa: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Ano de Nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Pessoa p = new Pessoa(nome, ano);
            p.ExibirDados();
            Console.ReadKey();
        }
        
    }    

}