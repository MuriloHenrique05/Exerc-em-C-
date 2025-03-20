using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança
{
    public class Carro:Veiculo
    {
        private string nome;
        public string Nome {get; set;}

        private string cor;
        public string Cor{get; set;}

        public Carro(string nome, string cor):base(4)
        {
            Desligado();
            //Rodas = 4;
            VelMax=120;
            this.Nome = nome;
            this.Cor = cor;
        }
    }
}