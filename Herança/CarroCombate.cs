using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança
{
    class CarroCombate:Carro
    {
        private int monicao;   
        public int Monicao{get;set;}
        public CarroCombate():base("Carro Combate","Verde")
        {
            Monicao = 100;
            SetarRodas(10);
        }
    }
}