using System;

namespace Calcular13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite os Meses: ");
            int meses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite seu Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Funcionario func = new Funcionario(nome,cpf,meses,salario);

            func.Mensagem();
        }
    }
}