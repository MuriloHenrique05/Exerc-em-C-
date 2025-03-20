using System;

namespace ClasseAb
{
     abstract class  Funcionario
    {
        private string nome;
        private decimal salario;
        
        public Funcionario(string rec_nome, decimal rec_salario)
        {
            nome = rec_nome;
            salario = rec_salario;
        }

        public string Nome
        {
        get{return this.nome;}
        set{this.nome = value;}
        }
        public decimal Salario
        {get{return this.salario;}
        set{this.salario = value;}
        }
        public abstract void Reajuste(decimal salreajuste);
    }
}