using System;

namespace Calcular13
{
    public class Funcionario
    {
        private string nome;
        private string cpf;
        private int meses;
        private double salario;

        public Funcionario(string nome_receb, string cpf_receb, int meses_receb, double salario_receb){
            this.Nome = nome_receb;
            this.CPF = cpf_receb;
            this.Meses = meses_receb;
            this.Salario = salario_receb;
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
        public double Salario
        {
            get{ return this.salario;}
            set{this.salario = value;}
        }

        public double Calcular(){
            return ((Salario/12) * Meses);
        }

        public void Mensagem(){
            Console.WriteLine("Nome do Funcionario é: " + this.Nome);
            Console.WriteLine("Seu Décimo Terceiro é: " + Calcular());
        }
    }
}