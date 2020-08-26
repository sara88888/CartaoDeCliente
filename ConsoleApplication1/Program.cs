
namespace ConsoleApplication1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = string.Empty;

            Console.WriteLine("Pretende efectuar vendas?");
            resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
                BalcaoLoja();
            else
                LojaOffice();
        }
        static void BalcaoLoja()
        { }
        static void LojaOffice()
        { }
 
    }
}
