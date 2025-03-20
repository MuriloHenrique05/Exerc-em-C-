using System;

namespace ClasseAb{

    class GerenteDeAgencia:Gerente{
    
    public GerenteDeAgencia(string nome, decimal salario):base(nome, salario){}
    public override void Reajuste(decimal salreajuste){
        Salario += salreajuste;
        }
    }
}