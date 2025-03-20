using System;

namespace Estudo
{
    // Classe ContaCorrente herda de Conta
     public class ContaCorrente : Conta
    {
        public ContaCorrente(long numero) : base(numero) { }

        // Implementação do método Sacar específico para ContaCorrente
        public override bool Sacar(decimal valor)
        {
            if (Saldo >= valor + 0.1m) // Considerando taxa de saque de 0.10
            {
                Saldo -= (valor + 0.1m); // Subtrai o valor do saque mais a taxa
                Console.WriteLine($"Saque de {valor} realizado com sucesso. Taxa de 0.10 aplicada. Saldo atual: {Saldo}");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                return false;
            }
        }
    }
}