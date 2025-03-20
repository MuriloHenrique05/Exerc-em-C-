using System;
using System.Collections.Generic;

namespace Estudo
{
 public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int AnoNascimento { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, int anoNascimento, string cpf)
        {
            if (DateTime.Now.Year - anoNascimento < 18)
                throw new ArgumentException("O Cliente deve ter mais de 18 anos!");
            if (cpf.Length != 11)
                throw new ArgumentException("O CPF deve possuir 11 digitos.");

            this.Nome = nome;
            this.AnoNascimento = anoNascimento;
            this.Cpf = cpf;
        }
    }
}