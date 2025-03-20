using System;

namespace ClasseAb{

    class Gerente:Funcionario{
     public Gerente(string nome, decimal salario):base(nome, salario){}
    
    public override void Reajuste(decimal salreajuste){
        Salario += salreajuste;
        }
    }
}