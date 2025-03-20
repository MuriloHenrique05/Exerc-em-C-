using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança
{
    public class Veiculo 
    {
        private int velmax;
        public int VelMax{get;set;}

        private bool ligado;
        public bool Ligado{get; set;}

        private int rodas;
        //public int Rodas{get; set;}

        public void Ligar()
        {
            Ligado = true;
        }

        public void Desligado()
        {
            Ligado = false;
        }

        public string SituacaoMotor()
        {
           /* if(Ligado)
            {
                return "sim";
            }
            else
            {
                return "Não";
            }*/

            return (Ligado? "Sim": "Não");
        }

        public Veiculo(int rodas){
            this.rodas=rodas;
        }

        public int GetRodas()
        {
            return rodas;
        }

        public void SetarRodas(int rodas)
        {
            if(rodas<0)
            {
                this.rodas=0;
            }else if(rodas>40)
            {
                this.rodas=40;
            }else
            {
                this.rodas = rodas;
            }
        }
    }
}