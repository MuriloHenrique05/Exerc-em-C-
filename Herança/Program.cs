using System;

namespace Herança
{
    internal class Program
    {
        private static void Main(string [] args)
        {
            Carro c1 = new Carro("Carro de Corrida", "Azul");
            Console.WriteLine("Nome.........:{0}", c1.Nome);
            Console.WriteLine("Cor.........:{0}", c1.Cor);
            Console.WriteLine("Rodas.........:{0}", c1.GetRodas());
            Console.WriteLine("Vel. Maxima.........:{0}", c1.VelMax);
            Console.WriteLine("Motor Ligado.........:{0}", c1.SituacaoMotor());

            Console.WriteLine("-----------------------------------------------------------------");

            Carro cc1 = new CarroCombate();
            cc1.Desligado();
            cc1.VelMax = 60;
            cc1.SetarRodas(25);
            Console.WriteLine("Nome.........:{0}", cc1.Nome);
            Console.WriteLine("Cor.........:{0}", cc1.Cor);
            Console.WriteLine("Rodas.........:{0}", cc1.GetRodas());
            Console.WriteLine("Vel. Maxima.........:{0}", cc1.VelMax);
            Console.WriteLine("Motor Ligado.........:{0}", cc1.SituacaoMotor());
            
            Console.ReadLine();
        }
    }
}