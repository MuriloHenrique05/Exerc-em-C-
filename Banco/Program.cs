using System;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitando dados do cliente
            Console.WriteLine("Digite o nome do cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o ano de nascimento do cliente:");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o CPF do cliente (11 dígitos):");
            string cpf = Console.ReadLine();

            // Criando o cliente
            Cliente cliente1 = new Cliente(nome, anoNascimento, cpf);

            // Perguntar se o cliente quer abrir uma conta corrente ou poupança
            Console.WriteLine("Escolha o tipo de conta para o cliente:");
            Console.WriteLine("1 - Conta Corrente");
            Console.WriteLine("2 - Conta Poupança");
            int tipoConta = int.Parse(Console.ReadLine());

            // Criando a conta com base na escolha
            Conta conta1 = null;
            if (tipoConta == 1)
            {
                Console.WriteLine("Digite o número da conta (deve ser maior que 9999):");
                long numeroConta = long.Parse(Console.ReadLine());
                conta1 = new ContaCorrente(numeroConta);
            }
            else if (tipoConta == 2)
            {
                Console.WriteLine("Digite o número da conta (deve ser maior que 9999):");
                long numeroConta = long.Parse(Console.ReadLine());
                conta1 = new ContaPoupanca(numeroConta);
            }

            conta1.Titular = cliente1;

            // Realizando depósito
            Console.WriteLine("Digite o valor a ser depositado na conta:");
            decimal valorDeposito = decimal.Parse(Console.ReadLine());
            conta1.Depositar(valorDeposito);

            // Se for uma Conta Poupança, aplicar rendimento
            if (conta1 is ContaPoupanca contaPoupanca)
            {
                contaPoupanca.AplicarRendimento();
            }

            // Realizando saque
            Console.WriteLine("Digite o valor a ser sacado da conta:");
            decimal valorSaque = decimal.Parse(Console.ReadLine());
            conta1.Sacar(valorSaque);

            // Perguntar se o cliente deseja transferir dinheiro para outra conta
            Console.WriteLine("Você deseja transferir dinheiro para outra conta? (sim/não)");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                // Escolher o tipo de conta de destino
                Console.WriteLine("Escolha o tipo de conta de destino:");
                Console.WriteLine("1 - Conta Corrente");
                Console.WriteLine("2 - Conta Poupança");
                int tipoContaDestino = int.Parse(Console.ReadLine());

                // Criar a conta de destino
                Conta contaDestino = null;
                if (tipoContaDestino == 1)
                {
                    Console.WriteLine("Digite o número da conta de destino (deve ser maior que 9999):");
                    long numeroContaDestino = long.Parse(Console.ReadLine());
                    contaDestino = new ContaCorrente(numeroContaDestino);
                }
                else if (tipoContaDestino == 2)
                {
                    Console.WriteLine("Digite o número da conta de destino (deve ser maior que 9999):");
                    long numeroContaDestino = long.Parse(Console.ReadLine());
                    contaDestino = new ContaPoupanca(numeroContaDestino);
                }

                // Realizar a transferência
                Console.WriteLine("Digite o valor a ser transferido:");
                decimal valorTransferencia = decimal.Parse(Console.ReadLine());
                conta1.Transferir(contaDestino, valorTransferencia);

                // Se for uma Conta Poupança, aplicar rendimento
                if (contaDestino is ContaPoupanca contaPoupancaDestino)
                {
                    contaPoupancaDestino.AplicarRendimento();
                }
            }

            // Exibindo saldo final
            Console.WriteLine($"Saldo final da conta {conta1.Numero} (Titular: {cliente1.Nome}): {conta1.Saldo}");
        }
    }
}