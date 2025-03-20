using System;

namespace ClasseAb{

    class AnalistaTi:Funcionario{

    public AnalistaTi(string nome, decimal salario):base(nome, salario){}
    
    public override void Reajuste(decimal salreajuste){
        Salario += salreajuste;
       }
    }
}    