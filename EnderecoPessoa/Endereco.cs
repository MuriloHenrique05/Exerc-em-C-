using System;

namespace EnderecoPessoa
{
    public class Endereco
    {
        private int id;
        public int Id
        {
            get { return this.id ; }
            set { this.id = value; }
        }

        private string rua;
        public string Rua
        {
            get { return this.rua; }
            set { this.rua = value; }
        }

        private string numero;
        public string Numero
        {
            get{ return this.numero; }
            set{ this.numero = value; }
        }

        private string cep;
        public string Cep
        {
            get { return this.cep; }
            set { this.cep = value; }
        }

        private Pessoa pessoa;

        public Pessoa Pessoa
        {
            get { return this.pessoa; }
            set { this.pessoa = value; }
        }
        

    }
}