using System;

namespace ClassePessoa
{
     public class Funcionario{
        private string nome;
        private string cpf;
        private int meses;

        public Funcionario(string nome_receb, string cpf_receb, int meses_receb){
            this.Nome = nome_receb;
            this.CPF = cpf_receb;
            this.Meses = meses_receb; 
        }
        public string Nome
        {
            get{return this.nome;}
            set{this.nome = value;}
        }
        public string CPF
        {
            get{return this.cpf;}
            set{this.cpf = value;}
        }
        public int Meses
        {
            get{return this.meses;}
            set{this.meses = value;}
        }

        public void Mensagem(){
            Console.WriteLine("Seu Nome é: " + this.Nome);
            Console.WriteLine("Seu CPF é :" + this.CPF);
            Console.WriteLine("Você tem: " + this.Meses + "Tabalhados");
        }
    }
}