using System;

namespace Estudo
{
    // Classe ContaPoupanca herda de Conta
    public class ContaPoupanca : Conta
    {
        private const decimal TaxaRendimento = 0.005m; // 0,5% ao mês

        public ContaPoupanca(long numero) : base(numero) { }

        // Método para aplicar rendimento mensal sobre o saldo
        public void AplicarRendimento()
        {
            decimal rendimento = Saldo * TaxaRendimento;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento de 0.5% aplicado. Rendimento: {rendimento}. Saldo atual: {Saldo}");
        }

        // Implementação do método Sacar específico para ContaPoupanca
        public override bool Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso. Saldo atual: {Saldo}");
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