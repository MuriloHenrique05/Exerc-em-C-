using System;

namespace CalculaIdade
{

    public class Pessoa
    {

    private int anoNascimento;

    public Pessoa()
    {
        this.Nome = "Murilo";
        this.AnoNascimento = 2000;
    }

    public Pessoa(string nome_recep, int anonascimento_recep)
    {
        this.Nome = nome_recep;
        this.AnoNascimento = anonascimento_recep;
        this.CalcularIdade();
    }

    public int AnoNascimento
    {
        get {return this.anoNascimento;}
        set {this.anoNascimento = value;}
    }

    private String nome;

    public String Nome
    {
        get {return this.nome;}
        set {this.nome = value.ToUpper();}
    }

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Ano de Nascimento : " + this.AnoNascimento);
        Console.WriteLine("Idade : " + this.CalcularIdade());
    }

    private int CalcularIdade()
    {
        DateTime data = DateTime.Now;
        int ano = data.Year;
        int idade = ano - this.AnoNascimento;
        return idade;
       } 
    }
}