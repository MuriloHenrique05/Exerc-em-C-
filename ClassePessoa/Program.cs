using System;

namespace ClassePessoa
{
    class Program
    {
        static void Main(string [] args){

            Console.WriteLine("Digite o Seu Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o Seu CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite os Meses Trabalhados: ");
            int meses = Convert.ToInt32(Console.ReadLine());

            Funcionario fun = new Funcionario(nome,cpf,meses);

            fun.Mensagem();
        }
    }    
}