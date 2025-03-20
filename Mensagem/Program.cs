using Mensagem;

namespace Mensagem
{

    class Program
    {
        private static void Main(string[] args)
        {
         ClasseMensagem msg1,msg2;

            msg1 = new ClasseMensagem();
            msg2 = new ClasseMensagem();

            msg1.setTextoMensagem("Primeiro Objeto");
            Console.WriteLine(msg1.getTextoMensagem());

            msg2.setTextoMensagem("Segundo Objeto");
            Console.WriteLine(msg2.getTextoMensagem());

            ClasseMensagem msg3 = new ClasseMensagem();
            msg3.setTextoMensagem("Terceiro Objeto");
            Console.WriteLine(msg3.getTextoMensagem());

            ClasseMensagem pessoa1= new ClasseMensagem();
            
            pessoa1.setNome("Murilo");
            pessoa1.setIdade(24);
            pessoa1.setTextoMensagem("Está bem novo!!");

            Console.WriteLine("Seu nome é : " + pessoa1.getNome());
            Console.WriteLine("Sua idade é : " + pessoa1.getIdade());
            Console.WriteLine("Daqui dez anos você terá " + pessoa1.Retornaidademais10() + "anos!!");
            Console.WriteLine("Uma mensagem de Esperança " + pessoa1.getTextoMensagem());
        }
    }
}

