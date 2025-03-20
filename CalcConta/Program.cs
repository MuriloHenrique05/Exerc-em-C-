using System;
using ContaBancaria; 

namespace CalcConta
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;
            double saldoinicial, vrmovimento;
            string cliente;

            Console.Clear();

            Console.Write("Digite o Nome do Cliente : ");
            cliente = Console.ReadLine().ToUpper();
            Console.Write("Digite o Saldo Inicial : ");
            saldoinicial = Convert.ToDouble(Console.ReadLine());
            Conta c = new Conta(cliente, saldoinicial);

            while (opcao != 4)
            {
                Console.Clear();
                Console.WriteLine("Escolha a Opção: ");
                Console.WriteLine("1 - Consultar Saldo");
                Console.WriteLine("2 - Depositar Valor");
                Console.WriteLine("3 - Sacar Valor");
                Console.WriteLine("4 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());



                if (opcao == 1)
                {
                    Console.Write("Cliente " + c.Nomecliente + " Tem Saldo : " + c.Saldo);
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite o Valor a Ser Depositado: ");
                    vrmovimento = Convert.ToDouble(Console.ReadLine());
                    c.Depositar(vrmovimento);
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o Valor a Ser Sacado: ");
                    vrmovimento = Convert.ToDouble(Console.ReadLine());
                    c.Sacar(vrmovimento);
                }
            }
        }
    }
}