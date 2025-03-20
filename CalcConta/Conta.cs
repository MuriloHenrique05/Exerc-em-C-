using System;

namespace ContaBancaria
{
    public class Conta
    {
        private string _cliente;
        private double _saldo;

        public Conta(string nome_recep, double saldo_recep)
        {
            this.Nomecliente = nome_recep;
            this.Saldo = saldo_recep;
        }

        public string Nomecliente
        {
            get { return this._cliente; }
            set { this._cliente = value; }
        }

        public double Saldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }

        public void Sacar(double valor)
        {
            if (this.Saldo < valor)
            {
                Console.WriteLine("O Saldo Atual é : " + this.Saldo + " Portanto, não há saldo suficiente para o Saque Solicitado!");
                Console.ReadLine();
            }
            else
            {
                this._saldo -= valor;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
    }
}