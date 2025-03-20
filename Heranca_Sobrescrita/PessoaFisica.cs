
using System;

namespace Heranca_Sobrescrita
{
    class PessoaFisica:Pessoa
    {
        private string _cpf;
        private string _rg;

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string RG
        {
            get { return _rg; }
            set { _rg = value; }
        }

        public PessoaFisica(string nome, string email, string telefone, string cpf, string rg):base(nome, email, telefone)
        {
            _cpf = cpf;
            _rg = rg;
        }

        public double ValorDeCopia(int quantidade)
        {
            double valorPessoa = base.ValorDeCopia(quantidade);
            Console.WriteLine("metodo fisica: " + valorPessoa);
            return valorPessoa + (quantidade * 1.0);
        }
    }
}

