using System;
using System.Diagnostics;
using ClasseAb;

class Program{
    private static void Main(string [] args)
    {
        Funcionario analista = new AnalistaTi("Gabriel", 2000);
        Funcionario gerenteDeTI = new GerenteTI("Matheus", 4000);
        Funcionario gerenteDeAgencia = new GerenteDeAgencia("Murilo",10000);
        Funcionario gerente = new Gerente("Bruna", 8000);

        Funcionario [] funcionarios = {analista, gerenteDeTI, gerenteDeAgencia, gerente};

        foreach(var funcionario in funcionarios){
                    Console.WriteLine($"Nome: {funcionario.Nome}, Salário Atual: {funcionario.Salario}");

            Console.Write("Digite o Reajuste: ");
            decimal reajuste = decimal.Parse(Console.ReadLine());

            funcionario.Reajuste(reajuste);

            Console.WriteLine($"Nome: {funcionario.Nome}, Salário Reajustado: {funcionario.Salario:C}");
            Console.WriteLine();
        }
    }
}