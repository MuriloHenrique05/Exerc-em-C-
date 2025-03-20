using System;
namespace EnderecoPessoa
{
public class Pessoa
{
private int id;
public int Id
{
get { return this.id; }
set { this.id = value; }
}
private string nome;
public string Nome
{
get { return this.nome; }
set { this.nome = value; }
}
private int idade;
public int Idade
{
get { return this.idade; }
set { this.idade = value; }
}
private string cpf; 
public string Cpf
{
get { return this.cpf; }
set { this.cpf = value; }
}
private List<Endereco> enderecos;
public List<Endereco> Enderecos
{
get { return this.enderecos; }
set { this.enderecos = value; }
}
public Pessoa()
{
Enderecos = new List<Endereco>(); 
}
}
}