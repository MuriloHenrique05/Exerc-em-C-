using System;

namespace Estudo
{
    // Classe abstrata Conta
    public abstract class Conta
    {
        public long Numero { get; set; }
        public decimal Saldo { get; set; }
        public Cliente Titular { get; set; }

        // Construtor da conta
        public Conta(long numero)
        {
            if (numero < 9999)
                throw new ArgumentException("O número da conta deve ser superior a 999!");
            this.Numero = numero;
        }

        // Método de depósito, que é compartilhado entre todas as contas
        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso. Saldo atual: {Saldo}");
        }

        // Método abstrato: cada tipo de conta deve implementar o saque
        public abstract bool Sacar(decimal valor);

        // Método para transferir entre contas
        public bool Transferir(Conta destino, decimal valor)
        {
            if (Sacar(valor))
            {
                destino.Depositar(valor);
                Console.WriteLine($"Transferência de {valor} realizada para a conta {destino.Numero}.");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar a transferência.");
                return false;
            }
        }
    }
}