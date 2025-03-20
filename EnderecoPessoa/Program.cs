using System;
namespace EnderecoPessoa
{
    class Program
    {
        private static void Main(string[] args)
        {
            Pessoa pes = new Pessoa();
            pes.Id = 1;
            pes.Nome = "Murilo Henrique Geronimo Falda";
            pes.Idade = 24;
            pes.Cpf = "123456789";
            Endereco ender1 = new Endereco();
            ender1.Id = 1;
            ender1.Rua = "Av. Primeira";
            ender1.Numero = "100";
            ender1.Cep = "1000000";
            Endereco ender2 = new Endereco();
            ender2.Id = 1;
            ender2.Rua = "Av. Segundo";
            ender2.Numero = "200";
            ender2.Cep = "2000000";
            //relacionamento entre os objetos 
            pes.Enderecos.Add(ender1);
            ender1.Pessoa = pes;
            pes.Enderecos.Add(ender2);
            ender2.Pessoa = pes;
            /* Apresentar Dados - Forma 1 */
            Console.WriteLine("APRESENTANDO DADOS - FORMA 1");
            Console.WriteLine(pes.Id + " " + pes.Nome);
            Console.WriteLine(ender1.Id + " " + ender1.Rua + " " + ender1.Numero + " " +
            ender1.Cep);
            Console.WriteLine(ender2.Id + " " + ender2.Rua + " " + ender2.Numero + " " +
            ender2.Cep);
            Console.ReadLine();
            Console.Clear();
            /* Apresentar Dados - Forma 2 */
            Console.WriteLine("APRESENTANDO DADOS - FORMA 2");
            Console.WriteLine(pes.Id + " " + pes.Nome);
            Console.WriteLine(pes.Enderecos[0].Id + " "
            + pes.Enderecos[0].Rua + " "
            + pes.Enderecos[0].Numero + " "
            + pes.Enderecos[0].Cep);
            Console.WriteLine(pes.Enderecos[1].Id + " "
            + pes.Enderecos[1].Rua + " "
            + pes.Enderecos[1].Numero + " "
            + pes.Enderecos[1].Cep);
            Console.ReadLine();
            Console.Clear();
            /* Apresentar Dados - Forma 3 */
            Console.WriteLine("APRESENTANDO DADOS - FORMA 3");
            Console.WriteLine(pes.Id + " " + pes.Nome);
            Endereco e1 = pes.Enderecos[0];
            Endereco e2 = pes.Enderecos[1];
            Console.WriteLine(e1.Id + " " + e1.Rua + " " + e1.Numero + e1.Cep);
            Console.WriteLine(e2.Id + " " + e2.Rua + " " + e2.Numero + e2.Cep);
            Console.ReadLine();
            Console.Clear();
            /* Apresentar Dados - Forma 4 */
            Console.WriteLine("APRESENTANDO DADOS - FORMA 4");
            Console.WriteLine(pes.Id + " " + pes.Nome);
            foreach (var e in pes.Enderecos)
            {
                Console.WriteLine(e.Id + " " + e.Rua + " " + e.Numero + e.Cep);
            }
            // observação */
            Console.WriteLine(pes.Enderecos[0].Pessoa.Idade);
        }
    }
}