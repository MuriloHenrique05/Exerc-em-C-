
using System;

namespace Heranca_Sobrescrita
{
   class Program
    {
        private static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica("Humberto", "humberto.antico@gmail.com", "149969655", "19154568134", "1321132131");

            Console.WriteLine("----------   Pessoa Física ----------");
            Console.WriteLine("Nome: " + pf.Nome);
            Console.WriteLine("E-mail: " + pf.Email);
            Console.WriteLine("Telefone: " + pf.Telefone);
            Console.WriteLine("CPF: " + pf.CPF);
            Console.WriteLine("Celular: " + pf.RG);
            Console.WriteLine("Valor Copia PF: " + pf.ValorDeCopia(2));

            PessoaJuridica pj = new PessoaJuridica("Humberto", "humberto.antico@gmail.com", "149969655", "19154560001", "HUMBERTO LTDA");

            Console.WriteLine("----------   Pessoa Jurídica ----------");
            Console.WriteLine("Nome: " + pj.Nome);
            Console.WriteLine("E-mail: " + pj.Email);
            Console.WriteLine("Telefone: " + pj.Telefone);
            Console.WriteLine("CPF: " + pj.CNPJ);
            Console.WriteLine("Celular: " + pj.NomeFantasia);
            Console.WriteLine("Valor Copia PF: " + pj.ValorDeCopia(2));
           


        }
    }
}
