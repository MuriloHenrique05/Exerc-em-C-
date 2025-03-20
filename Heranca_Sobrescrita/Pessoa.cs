
using System;

namespace Heranca_Sobrescrita
{
    class Pessoa
    {
        private string _nome;
        private string _email;
        private string _telefone;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public Pessoa(string nome, string email, string telefone)
        {
            _nome = nome;
            _email = email;
            _telefone = telefone;
        }

        public double ValorDeCopia(int quantidade)
        {
            return quantidade * 1.0;
        }
    }

}

