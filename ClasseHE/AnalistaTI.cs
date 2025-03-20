using System;

namespace ClasseHE
{
    class AnalistaTI:Funcionario
    {
        public AnalistaTI(string nome, decimal salario):base(nome, salario)
        {

        }

        public override void Reajuste(decimal salreajuste)
        {
            Salario += salreajuste;   
        }
    }
}