using System;

namespace CSharp_ProjetoSeguros
{
    internal static class MsgErro
    {
        public static void Erro1()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Foi digitado um caractere não numérico em um campo exclusivamente numérico. Pressione qualquer tecla para continuar.");
            Console.ReadLine();
        }

        public static void Erro2()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Escolha uma opção inserindo um valor inteiro de 1 a 5. Pressione qualquer tecla para continuar.");
            Console.ReadLine();
        }
    }
}
