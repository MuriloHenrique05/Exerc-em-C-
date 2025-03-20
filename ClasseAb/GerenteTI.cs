using System;

namespace ClasseAb{

    class GerenteTI:Gerente{
    
    public GerenteTI(string nome, decimal salario):base(nome, salario){}
    public override void Reajuste(decimal salreajuste){
        Salario += salreajuste;
        }
    }
}