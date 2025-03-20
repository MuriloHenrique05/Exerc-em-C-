using System;

namespace ExercicioIMC{

    public class Pessoa
    {
        private int calcimc;

        puclic Pessoa(float altura_recep, float peso_recep)
        {
            this.Altura = altura_recep;
            this.Peso = peso_recep;
            this.CalcularIMC();
        }

        public float Altura
        {
            get {return this.calcimc;}
            set {this.calcimc = value;}
        }
        public float Peso
        {
            get {return this.calcimc;}
            set {this.calcimc = value;}
        }
public void ExibirDados()
    {
       ;
        Console.WriteLine("Peso : " + this.Altura);
        Console.WriteLine("Altura : " + this.Peso);
    }
    }
}