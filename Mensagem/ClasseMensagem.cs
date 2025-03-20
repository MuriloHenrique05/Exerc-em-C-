using System;

namespace Mensagem
{

    class ClasseMensagem
    {
        private String TextoMensagem;

        private String Nome;
        private int Idade;

        public void setNome(String Rnome)
        {
            this.Nome = Rnome;
        }

        public string getNome(){
            return this.Nome;
        }

        public void setIdade(int Ridade)
        {
            this.Idade = Ridade;
        }

        public int getIdade(){
            return this.Idade;
        }

        public int Retornaidademais10()
        {
            return this.Idade + 10;
        }
        public void setTextoMensagem(String valor)
        {
           this.TextoMensagem = valor;
        }
        public String getTextoMensagem()
        {
            return this.TextoMensagem;
        }
    }
}